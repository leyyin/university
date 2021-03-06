=== Seminary 6. 8086 Interrupts. ===

Interrupt  - is an electrical signal sent through the control bus of
the cumputing system which signalises the occurence of an event

Interrupts can be generated by :
- hardware components: keyboard(when the user presses a key), network card, etc
- the cpu through software instructions: the cpu can generate an interrupt
when an exception occurs(e.g. division by zero) or as the result of the
instruction 'int'.

When the cpu detects an interrupt it does the following things:
- it suspends the execution of the current program
- it calls the interrupt handling routine(IHR) of that interrupt
- sometimes it resumes the execution of the suspended program

At software level an interrupt is identified by a natural number
The IHR of some interrupts performs different things depending on the
value from AH register; in this case we say the interrupt has several
functions or functionalities.
ex:
    1) mov AX, 4C00h
       int 21h
       - these instruction generates interrupt 21h whoose IHR checks the
       value from AH which is 4Ch and executes function 4Ch which
       ends/terminates the current program; AL contains the exit code 00h

    2) mov AH, 01h
       int 21h
       - generates interrupt 21h whose IHR executes function 01h which
       reads a character from the standard input device(i.e. the keyboard)
       and stores its ascii code in AL

    3) mov AH, 02h
       mov DL, 'a'
       int 21h
       - generates interrupt 21h whose IHR executes function 02h which
       prints to the standard output device(i.e. the screen/display)
       the character from DL


== Ex.1 ==
Write a program which reads the name of the file from the keyboard and
deletes that file if it exists.

ASSUME CS:code, DS:data

data SEGMENT
    msg DB 'Filename=', '$'
    filename DB 12, ?, 13 DUP(?) ; memory buffer(i.e. string) used for
                                 ; holding the name of the file
    errMsg DB 'Error deleting file', '$'
data ENDS

code SEGMENT
start:
    mov AX, data
    mov DS, AX

    ; we print msg on the screen using function 09h of interrupt 21h
    ; which prints the string with the address in DS:DX(these string must
    ; end with '$' sign)

    mov AH, 09h ; function name
    ; DS already contains the segment address of msg
    mov DX, offset msg ; <=> lea DX, msg
    int 21h ; generate the interrupt

    ; we read the name of the file from the standard input device using
    ; function 0Ah of interrupt 21h which reads a string and stores the
    ; string at the memory address DS:DX
    ; DS:DX should store the address of a memory buffer with the
    ; following structure:
    ; - at offset 0 we store the maximum number of characters that should
    ; be read
    ; - at offset 1 the IHR will return the actual number of read characters
    ; - starting at offset 2 the IHR will store the ascii code of the read
    ; characters

    mov AH, 0Ah ; the function name
    lea DX, filename
    int 21h ; generate the interrupt

    ; assuming we have read the string 'a.txt' filename will look like this
    ; see DRAWING 1

    ; filename variable in memory:
    ;
    ; +0    +1   +2      +3      +4      +5      +6      +7
    ; ------------------------------------------------------------------
    ; |   12|   5|    'a'|    '.'|    't'|    'x'|    't'|    |...
    ; -------------------------------------------------------------------
    ;
    ; filenamep[1] is the acutal number of read characters
    ; we need to put a 0 on filename[7]
    ;
    ; DRAWING 1

    ; in order to use function 41h of interrupt 21h we first need to
    ; transform the filename string into asciiz string (which is a string
    ; that ends in 0)
    ; the offset of the last character of filename is
    ; offset filename + filename[1] + 2
    mov AL, filename[1]
    mov AH, 0   ; unsigned conversion of AL to AX
    add AX, offset filename + 2
    mov SI, AX
    mov bytes PTR [SI], 0 ; put 0 at the end of filename

    ; we delete the file using function 41h of interrupt 21h which deletes
    ; the file with the name whose address is in DS:DX
    mov AH, 41h
    mov DX, offset filename + 2 ; <=> lea DX, filename + 2
    ; we use filename + 2 because the name of the file starts at offset
    ; 2 in the filename
    int 21h

    ; function 41h of interrupt 41h sets CF(carry flag) if an error occurs
    jnc the_end ; if CF != 1 jump to the end of the program
    ; else print an error message using function 09h of interrupt 21h
    mov AH, 09h
    mov DX, offset errMsg
    int 21h

    the_end:

    mov AX, 4C00h
    int 21h
code ENDS
END start



== Ex.2 ==
Write a program which prints on the screen the value in base 10 of AX and BX

ASSUME CS:code, DS:data

data SEGMENT
    msg1 DB 'AX=', '$'
    msg2 DB 'BX=', '$'
    newline DB 10, 13, '$' ; printing these 2 characters moves the writing
    ; prompt from the beggining of a new line
    ; 10 - is line feed
    ; 13 - carry return

    ten DW 10
data ENDS

code SEGMENT

print_base10 PROC ; define a procedure wich prints AX in base 10

    ; if AX is negative we print a minus sign
    cmp AX, 0h
    jge positive
    push AX ; save AX on the stack
    mov AH, 02h
    mov DL, '-'
    int 21h ; print '-'

    pop AX ; restore AX from the stack
    neg AX ; AX = |AX| - convert to absolute value

    positive:

    mov CX, 0 ; CX will store the number of digits we put on the stack
    repeat:
        ; in order to avoid situations in which the quotient of the division
        ; AX / 10 does not fit onto AL we always convert AX to DX:AX and divide it
        ; to a word with the value 10
        mov DX, 0
        div ten
        push DX ; put the digit which is the remainder on the stack

        inc CX
        cmp AX, 0
        ja repeat
        ; loop until the quotient is zero

    ; now we have to pop CX digits from the stack and print them on the screen
    get_digits:
        pop DX ; the digit is in DL
        add DL, '0' ; obtain the ascii code of the digit

        mov AH, 02h
        int 21h ; print the digit using function 02h of interrupt 21h

        loop get_digits

    ret ; return from procedure
print_base10 ENDP ; end of the procedure

start:
    mov AX, data
    mov DS, AX

    ; print the value of AX
    mov AH, 09h
    lea DX, msg1
    int 21h ; print msg1 to the screen

    call print_base10 ; call the procedure

    ; print a new line
    mov AH, 09h
    lea DX, newline
    int 21h

    ;print the value of BX
    mov AH, 09h
    lea DX, msg2
    int 21h ; print msg2 to the screen

    mov AX, BX
    call print_base10 ; print the value of BX in base 10

    mov AX, 4C00h
    int 21h
code ENDS
END start

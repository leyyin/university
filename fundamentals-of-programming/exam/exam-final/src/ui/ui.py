'''
Created on Jan 30, 2014

@author: daniel
'''
# http://python-future.org/compatible_idioms.html
from __future__ import print_function
from builtins import input


try:
    import readline
except ImportError:
    pass


class SpellChekerUI(object):
    def __init__(self, _spellc_controller, start_message=""):
        self._spellc_controller = _spellc_controller
        self._start_message = start_message
        self._menu = {
            "q": self.cmd_quit,
            "h": self.cmd_help,
            "1": self.cmd_add_word,
            "2": self.cmd_spellc_phrase,
            "3": self.cmd_spellc_file
        }

    def run(self):
        """
        The main loop
        """
        print(self._start_message)
        self.cmd_help()

        while True:

            command = self.get_cmd()
            while command not in self._menu:
                print("Command not valid please try again")
                command = self.get_cmd()

            # execute the command
            self._menu[command]()

    def get_menu(self):
        return """
Help menu:
1. Add word
2. Spellcheck phrase
3. Spellcheck file

h. Display this help menu
q. Quit
        """

    def get_cmd(self):
        """
        Get the command from the user
        """
        try:
            return input(">>> ").strip()
        except KeyboardInterrupt:
            print("Control-C pressed quiting")
            return "q"

    def cmd_spellc_phrase(self):
        """
        Spellcheck a phrase
        """
        lang = input("Language: ").strip().capitalize()
        phrase = input("Phrase: ").strip()

        print(self._spellc_controller.check_phrase(lang, phrase))

    def cmd_spellc_file(self):
        """
        Spellcheck a file
        """
        lang = input("Language: ").strip().capitalize()
        input_file_name = input("Input filename: ").strip()
        output_file_name = input("Output filename: ").strip()

        print(self._spellc_controller.check_filename(input_file_name, lang, output_file_name))

    def cmd_add_word(self):
        """
        Add a word
        """
        print("Add word")

        word_id = input("Word id: ").strip()
        word_lang = input("Word language: ").strip().capitalize()
        word_word = input("Word: ").strip()

        not_words = self._spellc_controller.add_word(word_id, word_lang, word_word)
        if not not_words:
            print("All words are in the dictionary")
        else:
            print(not_words)

    def cmd_quit(self):
        exit("Bye bye.")

    def cmd_help(self):
        print(self.get_menu())

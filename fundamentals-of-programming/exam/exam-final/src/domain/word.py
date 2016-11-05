'''
Created on Jan 30, 2014

@author: daniel
'''


class Word(object):
    def __init__(self, id, lang, word):
        self.__id = id
        self.__lang = lang
        self.__word = word

    def __str__(self):
        return "ID=" + str(self.id) + " Lang=" + self.lang + " Word=" + self.word

    def get_id(self):
        return self.__id

    def get_lang(self):
        return self.__lang

    def get_word(self):
        return self.__word

    def set_id(self, value):
        self.__id = value

    def set_lang(self, value):
        self.__lang = value

    def set_word(self, value):
        self.__word = value

    def del_id(self):
        del self.__id

    def del_lang(self):
        del self.__lang

    def del_word(self):
        del self.__word

    id = property(get_id, set_id, del_id, "id's docstring")
    lang = property(get_lang, set_lang, del_lang, "lang's docstring")
    word = property(get_word, set_word, del_word, "word's docstring")

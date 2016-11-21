# -*- coding: utf-8 -*-

def ProccessCrypt(line, k,encode=True):
    try:
        k = int(k)
    except:
        k = 3

    alph = [
        [u'abcdefghijklmnopqrstuvwxyz',26],
        [u'абвгдеёжзийклмнопрстуфхцчшщъыьэюя',33],
        [u'0123456789',10]
    ]
    line = line.lower()
    result = ''
    for ind_line_char in range(0,len(line)):      
        ind_alph = 0
        x = -1

        for ind_alph in range(0,3):
            x = alph[ind_alph][0].find(line[ind_line_char])
            if x != -1:
                break

        if x != -1:
            if encode:
                y = (x+k) % alph[ind_alph][1]
            else:
                y = (x-k+alph[ind_alph][1]) % alph[ind_alph][1]
            result += (alph[ind_alph][0][y])
        else:
            result += line[ind_line_char]
    return result

# coding: utf8
import sys
import argparse

alph = [
            ['abcdefghijklmnopqrstuvwxyz',26],
            ['абвгдеёжзийклмнопрстуфхцчшщъыьэюя',33],
            ['0123456789',10]
        ]

in_f = None
out_f = None
         
def Argv(argv):
    parser = argparse.ArgumentParser()
    parser.add_argument ('input', help='path input file')
    parser.add_argument ('-k', '--key',action='store',type=int, help='key encrypt',default=3)
    parser.add_argument ('-d', '--decrypt', action='store_false', help='flag decrpyt')
    parser.add_argument ('-o',  '--output', action='store', default='output.txt',
                         help='path output file')

    namespace = parser.parse_args(argv)
     
    return namespace

def ProccessCrypt(k,encode=True):
    for line in in_f:
        line = line.lower()
        for ind_line_char in range(0,len(line)):
            ind_alph = 0 # индекс алфавита
            x = -1 # индекс символа 
            #определим алфавит
            for ind_alph in range(0,3):
                x = alph[ind_alph][0].find(line[ind_line_char])
                if x != -1:
                    break
            #шифруем
            if x != -1:
                if encode:
                    y = (x+k) % alph[ind_alph][1]
                else:
                    y = (x-k+alph[ind_alph][1]) % alph[ind_alph][1]
                out_f.write(alph[ind_alph][0][y])
            else:
                out_f.write(line[ind_line_char])    
            

    

def main(key,path_in_f, path_out_f, decode):
    global in_f
    global out_f
    try:
        in_f = open(path_in_f, 'r',encoding='utf-8')
        out_f = open(path_out_f, 'w',encoding='utf-8')
        ProccessCrypt(key,decode)
        in_f.close()
        out_f.close()
    except:
        print (sys.exc_info()[1])
        return 1

        

if __name__ == '__main__':
    namespace = Argv(sys.argv[1:])
    main(namespace.key,
         namespace.input,
         namespace.output,
         namespace.decrypt)

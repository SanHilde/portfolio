#	1. Writ a function which generates a six digit/character random_user_id.
#	  print(random_user_id());
#	  '1ee33d'

from random import random, randint

def random_user_id ():
    cant_n = 0
    user_id  = ''
    while cant_n < 6:
        id_part = randint (48,122)
        if (id_part > 57 and id_part < 65) or (id_part > 90 and id_part < 97) :
            continue    
        else:
            #print (chr(id_part))
            user_id = user_id +  chr(id_part)
            cant_n+=1
    return user_id
print (random_user_id ())

#	2. Modify the previous task. Declare a function named user_id_gen_by_user. It doesn’t take any parameters but it takes two inputs using input(). 
# One of the inputs is the number of characters and the second input is the number of IDs which are supposed to be generated.
#	print(user_id_gen_by_user()) # user input: 5 5
#	#output:
#	#kcsy2
#	#SMFYb
#	#bWmeq
#	#ZXOYh
#	#2Rgxf
#	   
#	print(user_id_gen_by_user()) # 16 5
#	#1GCSgPLMaBAVQZ26
#	#YD7eFwNQKNs7qXaT
#	#ycArC5yrRupyG00S
#	#UbGxOFI7UXSWAyKN
#	#dIV0SSUTgAdKwStr
def user_id_gen_by_user ():
    print ("Ingrese la cantidad de ids a generar:")
    cant_de_ids = int(input())
    print ("Ingrese la cantidad de letras a generar en el id:")
    cant_de_letras = int(input())
    id_totales = 0
    cant_n = 0
    user_id  = ''
    while id_totales < cant_de_ids:
        while cant_n < cant_de_letras:
            id_part = randint (48,122)
            if (id_part > 57 and id_part < 65) or (id_part > 90 and id_part < 97) :
                continue    
            else:
                #print (chr(id_part))
                user_id = user_id +  chr(id_part)
                cant_n+=1
        print (user_id)
        if cant_n == cant_de_letras:
            cant_n = 0
            user_id  = ''
        id_totales+=1
        
user_id_gen_by_user ()

#	3. Write a function named rgb_color_gen. It will generate rgb colors (3 values ranging from 0 to 255 each).
def rgb_color_gen ():
    id_part_uno = randint (0,255)
    id_part_dos = randint (0,255)
    id_part_tres = randint (0,255)
    return ("rgb({},{},{})".format (id_part_uno,id_part_dos,id_part_tres))

print(rgb_color_gen())
#	# rgb(125,244,255) - the output should be in this form
#	Exercises: Level 2
#	1. Write a function list_of_hexa_colors which returns any number of hexadecimal colors in an array (six hexadecimal numbers written after #. Hexadecimal numeral system is 
# made out of 16 symbols, 0-9 and first 6 letters of the alphabet, a-f. Check the task 6 for output examples).
def hexa_colors ():
    cant_n = 0
    user_id  = ''
    while cant_n < 6:
        id_part = randint (48,102)
        if (id_part > 57 and id_part < 97) :
            continue    
        else:
            #print (chr(id_part))
            user_id = user_id +  chr(id_part)
            cant_n+=1
    return user_id
print (hexa_colors ())

def list_of_hexa_colors (cantidad):
    enviados= 0
    lista_hexa = list()
    while enviados<cantidad:
        lista_hexa.append(hexa_colors())
        enviados+=1
    return lista_hexa

print (list_of_hexa_colors (3))
#	2. Write a function list_of_rgb_colors which returns any number of RGB colors in an array.

def list_of_rgb_colors (cantidad):
    enviados= 0
    lista_rgb = list()
    while enviados<cantidad:
        lista_rgb.append(rgb_color_gen())
        enviados+=1
    return lista_rgb

print (list_of_rgb_colors (5))

#	3. Write a function generate_colors which can generate any number of hexa or rgb colors.
def generate_colors (tipo, cantidad):
    if tipo == 'hexa' :
        print (list_of_hexa_colors (cantidad))
    else:
        print (list_of_rgb_colors (cantidad))

generate_colors('hexa', 3) # ['#a3e12f','#03ed55','#eb3d2b'] 
generate_colors('hexa', 1) # ['#b334ef']
generate_colors('rgb', 3)  # ['rgb(5, 55, 175','rgb(50, 105, 100','rgb(15, 26, 80'] 
#	   generate_colors('rgb', 1)  # ['rgb(33,79, 176)']

#	Exercises: Level 3
#	1. Call your function shuffle_list, it takes a list as a parameter and it returns a shuffled list
def shuffle_list (parametro):
    #shuffle_lis_a = list()
    #shuffle_list_a= random.sample (parametro, len (parametro))
    #random.shuffle (parametro, len (parametro))
    #return shuffle_list_a
    return parametro
print (shuffle_list(['banana', 'orange', 'mango', 'lemon']))
#	2. Write a function which returns an array of seven random numbers in a range of 0-9. All the numbers must be unique.
def seven_number ():
    contador = 0
    palabra=''
    numero_generado= list()
    while contador<7:
        n=randint (0,9)
        #print (n)
        if n in numero_generado:
            continue
        else:
            numero_generado.append (n)
            contador+=1
    print (numero_generado)
    contador=len (numero_generado)-1
    while contador > -1:
        palabra=palabra+str(numero_generado[contador])
        contador-=1
    return palabra

print (seven_number())

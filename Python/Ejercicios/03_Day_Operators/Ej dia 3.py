#Declare your age as integer variable
age = 27
#Declare your height as a float variable
heigh = 1.88
#Declare a variable that store a complex number
complex_numer = 1+1j
#Write a script that prompts the user to enter base and height of the triangle and calculate an area of this triangle (area = 0.5 x b x h
base = int(input ('Ingrese base de triangulo = '))
altura = int(input ('Ingrese altura de triangulo = '))
area_triangulo = base * altura * 0.5
print ('Resultado area = ',area_triangulo)

#Write a script that prompts the user to enter side a, side b, and side c of the triangle. Calculate the perimeter of the triangle (perimeter = a + b + c).
side_A = int(input ('Ingrese lado A = '))
side_B = int(input ('Ingrese lado B = '))
side_C = int(input ('Ingrese lado C = '))
perimeter_triangulo = side_A+side_B+side_C
print ('Resultado perimetro = ',perimeter_triangulo)

#Get length and width of a rectangle using prompt. Calculate its area (area = length x width) and perimeter (perimeter = 2 x (length + width))
length = int(input ('Ingrese largo de rectangulo = '))
width = int(input ('Ingrese ancho de rectangulo = '))
area_rectangulo = length * width
perimeter_cuadrado = 2 * (length + width)
print ('Resultado area = ',area_rectangulo)
print ('Resultado perimetro = ',perimeter_cuadrado)
#Get radius of a circle using prompt. Calculate the area (area = pi x r x r) and circumference (c = 2 x pi x r) where pi = 3.14.
radius = int(input ('Ingrese radio del circulo = '))
area_circulo = 3.14* radius * radius
circumference = 2* 3.14* radius
print ('Resultado area = ',area_circulo)
print ('Resultado perimetro = ',circumference)
#Calculate the slope, x-intercept and y-intercept of y = 2x -2
#Slope is (m = y2-y1/x2-x1). Find the slope and Euclidean distance between point (2, 2) and point (6,10)
#Compare the slopes in tasks 8 and 9.
#Calculate the value of y (y = x^2 + 6x + 9). Try to use different x values and figure out at what x value y is going to be 0.
valor_equis = int(input ('Ingrese el valor de x para que la formula "y = x^2 + 6x + 9" de 0. X='))
incognita = valor_equis^2+6*valor_equis+9
print ('Resultado=', incognita)

#Find the length of 'python' and 'dragon' and make a falsy comparison statement.
print (len ('python') < len ('dragon'))
#Use and operator to check if 'on' is found in both 'python' and 'dragon'
print ('on in python: ', 'on' in 'python')
print ('on in python: ', 'on' in 'python')

#I hope this course is not full of jargon. Use in operator to check if jargon is in the sentence.
print ('jargon in the sentence: ', 'jargon' in "I hope this course is not full of jargon")

#There is no 'on' in both dragon and python
print ('is no "on" in dragon and python ', 'on' not in "dragon and python")

#Find the length of the text python and convert the value to float and convert it to string
python_len = print (type (float (len ('python'))))
print (type (str (python_len)))

#Even numbers are divisible by 2 and the remainder is zero. How do you check if a number is even or not using python?
variable = int (input ('Ingrese un numero que dividido por 2, su restante sea 0: '))
print ((variable %2) == 0 )

#Check if the floor division of 7 by 3 is equal to the int converted value of 2.7.
variable_dos = 7//3
varible_tres = int (2.7)
print ("The floor division of 7 by 3 is equal to the int converted value of 2.7: ", variable_dos == varible_tres)

#Check if type of '10' is equal to type of 10
print ("Check if type of '10' is equal to type of 10: ", '10' == 10)

#Check if int('9.8') is equal to 10

print ("int('9.8') is equal to 10: ", int (9.8) == 10)

#Writ a script that prompts the user to enter hours and rate per hour. Calculate pay of the person?
hours = int(input ('Ingrese cuantas horas trabajo = '))
rate_hours = int(input ('Ingrese cuanto gana por hora = '))
print ("El pago sera de: " , hours * rate_hours)

#Write a script that prompts the user to enter number of years. Calculate the number of seconds a person can live. Assume a person can live hundred years
years_live = int(input ('Ingrese cuantos anios quiere calcular = '))
print ("Los anios ingresados equivalen a: ", years_live*365*24*60*60, ' segundos')
#Write a Python script that displays the following table
a=1
while a<=5:
    print (a, 1, a*1, a*a, a*a*a)
    a=a+1
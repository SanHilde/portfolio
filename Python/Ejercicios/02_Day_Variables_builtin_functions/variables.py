#Exercises: Level 1
#Inside 30DaysOfPython create a folder called day_2. Inside this folder create a file named variables.py
#Write a python comment saying 'Day 2: 30 Days of python programming'
#Declare a first name variable and assign a value to it
first_name = 'Santiago'
#Declare a last name variable and assign a value to it
last_name = 'Hildebrandt'
#Declare a full name variable and assign a value to it
full_name = (first_name, last_name)
#Declare a country variable and assign a value to it
country = 'Argentina'
#Declare a city variable and assign a value to it
city = "Buenos Aires"
#Declare an age variable and assign a value to it
age = 27.5
#Declare a year variable and assign a value to it
year = 2023
#Declare a variable is_married and assign a value to it
is_married = False
#Declare a variable is_true and assign a value to it
is_true = True
#Declare a variable is_light_on and assign a value to it
is_light_on = False
#Declare multiple variable on one line
studies , sport , work = "Universitarios", 'Basket', 'Empleado'
print ('su trabajo es: ' , work)
#Exercises: Level 2
#Check the data type of all your variables using type() built-in function

print(first_name, type (first_name))
print(last_name, type (last_name))
print(country, type (country))
print(city, type (city))
print(age, type (age))
print(year, type (year))
print(is_married, type (is_married))
print(is_true, type (is_true))
print(is_light_on, type (is_light_on))
print(studies, type (studies))
print(sport, type (sport))
print(work, type (work))

#Using the len() built-in function, find the length of your first name
print ("Largo del nombre:" , len (first_name))
#Compare the length of your first name and your last name
if (len(first_name)<len (last_name)) : print ("Apellido es mas largo")
if (len(first_name)>len (last_name)) : print ("Nombre es mas largo")
if (len(first_name)==len (last_name)) : print ("Son iguales")

#Declare 5 as num_one and 4 as num_two
num_one = 5
num_two = 4
#Add num_one and num_two and assign the value to a variable total
total = num_one + num_two
#Subtract num_two from num_one and assign the value to a variable diff
diff = num_one-num_two
#Multiply num_two and num_one and assign the value to a variable product
product = num_one * num_two
#Divide num_one by num_two and assign the value to a variable division
division = float(num_one/num_two)
#Use modulus division to find num_two divided by num_one and assign the value to a variable remainder
remainder = num_two%num_one
#Calculate num_one to the power of num_two and assign the value to a variable exp
exp = num_one^num_two
#Find floor division of num_one by num_two and assign the value to a variable floor_division
floor_division = num_one//num_two

#The radius of a circle is 30 meters.
radius = 30
#Calculate the area of a circle and assign the value to a variable name of area_of_circle
area_of_circle = 3.14 * float(radius^2)
#Calculate the circumference of a circle and assign the value to a variable name of circum_of_circle
circum_of_circle = 3.14 * float (radius)
print ("total = ", total)
print ("diff = ", diff)
print ("product = ", product)
print ("division = ", division)
print ("remainder = ", remainder)
print ("exp = ", exp)
print ("floor_division = ", floor_division)
print ("area_of_circle = ", area_of_circle)
print ("circum_of_circle = ", circum_of_circle)

#Take radius as user input and calculate the area.
radius = int (input ("Ingrese radio nuevo: "))
area_of_circle = 3.14 * float(radius^2)
circum_of_circle = 3.14 * float (radius)
print ("area_of_circle = ", area_of_circle)
print ("circum_of_circle = ", circum_of_circle)
#Use the built-in input function to get first name, last name, country and age from a user and store the value to their corresponding variable names

first_name = input ("Ingrese nuevo nombre: ")
last_name = input ("Ingrese nuevo apellido: ")
country = input ("Ingrese nuevo pais: ")
city = input ("Ingrese nueva ciudad: ")
age = input ("Ingrese nueva edad: ")

print(first_name, type (first_name))
print(last_name, type (last_name))
print(country, type (country))
print(city, type (city))
print(age, type (age))

#Run help('keywords') in Python shell or in your file to check for the Python reserved words or keywords

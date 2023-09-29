#	Exercises: Level 1
#	1. Get user input using input(“Enter your age: ”). If user is 18 or older, give feedback: You are old enough to drive. If below 18 give feedback to wait for the missing amount of years. Output:
#	Enter your age: 30
#	You are old enough to learn to drive.
#	Output:
#	Enter your age: 15
#	You need 3 more years to learn to drive.

edad = int (input ("Enter your age:"))
if edad > 17:
    print ("You are old enough to learn to drive.")
else :
    print ("You need {} more year/s to learn to drive". format(18-edad))

#	2. Compare the values of my_age and your_age using if … else. Who is older (me or you)? Use input(“Enter your age: ”) to get the age as input. You can use a nested condition 
# to print 'year' for 1 year difference in age, 'years' for bigger differences, and a custom text if my_age = your_age. Output:
#	Enter your age: 30
#	You are 5 years older than me.
edad_my = int (input ("Enter your age:"))
edad_their = int (input ("Enter his/her age:"))
if edad_my > edad_their :
    if edad_my-edad_their== 1:
        print ('I am 1 year older than you')
    else:
       print ('I am {} years older than you'.format (edad_my-edad_their)) 
elif edad_my < edad_their :
    if edad_their-edad_my== 1:
        print ('You are 1 year older than me')
    else:
       print ('You are {} years older than me'.format (edad_their-edad_my))
else :
    print ('We are both same age')

#	3. Get two numbers from the user using input prompt. If a is greater than b return a is greater than b, if a is less b return a is smaller than b, else a is equal to b. Output:
#	Enter number one: 4
#	Enter number two: 3
#	4 is greater than 3
a = int (input ("Enter a number:"))
b = int (input ("Enter a second number:"))
if a < b :
       print ('a is smaller than b') 
elif a > b :
       print ('a is greater than b')
else :
    print ('a is equal to b')

#	### Exercises: Level 2
#	1. Write a code which gives grade to students according to theirs scores:
#	80-100, A
#	70-89, B
#	60-69, C
#	50-59, D
#	0-49, F
score = int (input ("Enter a score:"))
if score >= 90:
    print ('Your grade is A')
elif score >= 70:
    print ('Your grade is B')
elif score >= 60:
    print ('Your grade is C')
elif score >= 50:
    print ('Your grade is D')
else : 
    print ('Your grade is F')

#	2. Check if the season is Autumn, Winter, Spring or Summer. If the user input is: September, October or November, the season is Autumn. December, January or February, 
# the season is Winter. March, April or May, the season is Spring June, July or August, the season is Summer
Autumn = ['September', 'October' , 'November']
Winter = ['December', 'January' , 'February']
Spring = ['March', 'April' , 'May']
Summer = ['June', 'July' , 'August']
month =  input ("Enter a month:")
if month in Autumn:
    print ('It is Autum')
elif month in Winter:
    print ('It is Winter')
elif month in Summer:
    print ('It is Summer')
elif month in Spring:
    print ('It is Spring')
else:
    print ('That is not a month')

#	3. The following list contains some fruits:
fruits = ['banana', 'orange', 'mango', 'lemon']
#	If a fruit doesn't exist in the list add the fruit to the list and print the modified list. If the fruit exists print('That fruit already exist in the list')
fruit =  input ("Enter a fruit:")
if fruit in fruits:
    print ('That fruit already exist in the list')
else:
    fruits.append(fruit)
    print (fruits)

#	Exercises: Level 3
#	4. Here we have a person dictionary. Feel free to modify it!
person={
	    'first_name': 'Asabeneh',
	    'last_name': 'Yetayeh',
	    'age': 250,
	    'country': 'Finland',
	    'is_marred': True,
	    'skills': ['JavaScript', 'React', 'Node', 'MongoDB', 'Python'],
	    'address': {
	        'street': 'Space street',
	        'zipcode': '02210'
	    }
	    }
#	 * Check if the person dictionary has skills key, if so print out the middle skill in the skills list.
#	 * Check if the person dictionary has skills key, if so check if the person has 'Python' skill and print out the result.
#	 * If a person skills has only JavaScript and React, print('He is a front end developer'), if the person skills has Node, Python, MongoDB, print('He is a backend developer'), 
# if the person skills has React, Node and MongoDB, Print('He is a fullstack developer'), else print('unknown title') - for more accurate results more conditions can be nested!
#	 * If the person is married and if he lives in Finland, print the information in the following format:
if 'skills' in person:
    print (person['skills'][int(len(person['skills'])/2)])
    if 'Python' in person['skills']:
        print ("Python esta en las skilss")
    if 'JavaScript' in person['skills'] and 'React' in person['skills']:
        print ("He is a front end developer")
    if 'Node' in person['skills'] and 'React' in person['skills'] and 'MongoDB' in person['skills']:
        print ("He is a backend developer")
    if 'Node' in person['skills'] and 'Python' in person['skills'] and 'MongoDB' in person['skills']:
        print ("He is a fullstack developer")
    else:
        print ("unknown title")        
else:
    print ("No hay skilss")

if person['is_marred'] == True and  person['country'] == 'Finland':
    print ("{} {} lives in {}. He is married.".format( person['first_name'],person['last_name'],person['country']))
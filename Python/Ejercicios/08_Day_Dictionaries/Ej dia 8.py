#	1. Create an empty dictionary called dog
dog = {}
#	2. Add name, color, breed, legs, age to the dog dictionary
dog['name']= 'Taqui'
dog['color']= 'Brown'
dog['breed']= 'Callejero'
dog['legs']= 'Four'
dog['age']= '10'

#	3. Create a student dictionary and add first_name, last_name, gender, age, marital status, skills, country, city and address as keys for the dictionary
student = {
'first_name': 'Santiago',
'last_name' : 'Hildebrandt',
'gender' : "Male",
'age' : 27,
'marital_status' : 'Single',
'skills' : ['Basket', 'Designer', 'Programmer'],
'country': 'Argentina',
'city': "Buenos Aires",
'address' : {
        'street':'Italia',
        'zipcode':'946'
    }
}

#	4. Get the length of the student dictionary
student['length'] = 1.85

#	5. Get the value of skills and check the data type, it should be a list
print (type (student['skills']))

#	6. Modify the skills values by adding one or two skills
student['skills'].append ('Robot simulator')
print (student)

#	7. Get the dictionary keys as a list
print (student.keys())

#	8. Get the dictionary values as a list
print (student.values ())

#	9. Change the dictionary to a list of tuples using items() method
print (student.items())

#	10. Delete one of the items in the dictionary
del student['city']
print (student)
#	11. Delete one of the dictionaries
del dog

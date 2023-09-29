#	1. Concatenate the string 'Thirty', 'Days', 'Of', 'Python' to a single string, 'Thirty Days Of Python'.
ej_uno = ['Thirty', 'Days', 'Of', 'Python']
result_uno = ' '.join(ej_uno)
print(result_uno) 

#	2. Concatenate the string 'Coding', 'For' , 'All' to a single string, 'Coding For All'.
ej_dos = ['Coding', 'For', 'All']
result_dos = ' '.join(ej_dos)
print(result_dos) 
#	3. Declare a variable named company and assign it to an initial value "Coding For All".
company = "Coding For All"
#	4. Print the variable company using print().
print (company)

#	5. Print the length of the company string using len() method and print().
print (len (company))

#	6. Change all the characters to uppercase letters using upper() method.
print (company.upper ())

#	7. Change all the characters to lowercase letters using lower() method.
print (company.lower ())

#	8. Use capitalize(), title(), swapcase() methods to format the value of the string Coding For All.
print(company.capitalize())
print(company.title())
print(company.swapcase())

#	9. Cut(slice) out the first word of Coding For All string.
print(company.split(' ',1))

#	10. Check if Coding For All string contains a word Coding using the method index, find or other methods.
sub_string = 'Coding'
contiene = (company.find(sub_string))  # 16
print ("Contine la palabra:" , contiene > -1)

#	11. Replace the word coding in the string 'Coding For All' to Python.
new_name= (company.replace ('Coding', 'Python' ))
print (new_name)

#	12. Change Python for Everyone to Python for All using the replace method or other methods.
new_name= (new_name.replace ('All', 'Everyone' ))
print (new_name)

#	13. Split the string 'Coding For All' using space as the separator (split()) .
print (company.split (' '))

#	14. "Facebook, Google, Microsoft, Apple, IBM, Oracle, Amazon" split the string at the comma.
string = "Facebook, Google, Microsoft, Apple, IBM, Oracle, Amazon"
print (string.split (', '))

#	15. What is the character at index 0 in the string Coding For All.
print ("La letra en el index 0 es:" , company[0])

#	16. What is the last index of the string Coding For All.
print ("El utimo index es:" , len(company))

#	17. What character is at index 10 in "Coding For All" string.
print ("La letra en el index 10 es:" , company[10])

#	18. Create an acronym or an abbreviation for the name 'Python For Everyone'.
print (new_name[0:2]+new_name[6:(len(new_name)-3)])
print (new_name[0:(len(new_name)):2])

#	19. Create an acronym or an abbreviation for the name 'Coding For All'.
print (new_name[0:(len(new_name)):2]+ new_name[1:(len(new_name)):2] )

#	20. Use index to determine the position of the first occurrence of C in Coding For All.
print ("La prmer letra C esta en:" , company.find ('C'))

#	21. Use index to determine the position of the first occurrence of F in Coding For All.
print ("La prmer letra F esta en:" , company.find ('F'))

#	22. Use rfind to determine the position of the last occurrence of l in Coding For All People.
print ("La prmer letra l esta en:" , company.rfind ('l'))

#	23. Use index or find to find the position of the first occurrence of the word 'because' in the following sentence: 'You cannot end a sentence with because because because is a conjunction'
oracion_uno  = "You cannot end a sentence with because because because is a conjunction"
print ("El primer 'because' esta en el index:" , oracion_uno.find ('because'))

#	24. Use rindex to find the position of the last occurrence of the word because in the following sentence: 'You cannot end a sentence with because because because is a conjunction'
sub_palabra = 'because'
print ("El ultimo 'because' esta en el index:" , oracion_uno.rindex (sub_palabra))

#	25. Slice out the phrase 'because because because' in the following sentence: 'You cannot end a sentence with because because because is a conjunction'
print (oracion_uno.replace (' because because because ', ' '))

#	26. Find the position of the first occurrence of the word 'because' in the following sentence: 'You cannot end a sentence with because because because is a conjunction'
print ("El primer 'because' esta en el index:" , oracion_uno.find ('because'))

#	27. Slice out the phrase 'because because because' in the following sentence: 'You cannot end a sentence with because because because is a conjunction'
#	28. Does ''Coding For All' start with a substring Coding?
print ( 1== company.count ('Coding'))

#	29. Does 'Coding For All' end with a substring coding?
print ( company.endswith ('Coding'))

#	30. '   Coding For All      '  , remove the left and right trailing spaces in the given string.
oracion_dos = '   Coding For All      '
print (oracion_dos[oracion_dos.find ('C'):oracion_dos.rfind ('l')+1])

#	31. Which one of the following variables return True when we use the method isidentifier():
oracion_tres = ('30DaysOfPython')
print(oracion_tres.isidentifier())
oracion_cuatro = 'thirty_days_of_python'
print( oracion_cuatro.isidentifier ())

#	32. The following list contains the names of some of python libraries: ['Django', 'Flask', 'Bottle', 'Pyramid', 'Falcon']. Join the list with a hash with space string.
oracion_cinco = ['Django', 'Flask', 'Bottle', 'Pyramid', 'Falcon']
print ("# ".join (oracion_cinco ))

#	33. Use the new line escape sequence to separate the following sentences
oracion_seis = "I am enjoying this challenge."
print (oracion_seis.split (' '))

oracion_siete = "I just wonder what is next."
print (oracion_siete.split (' '))

#Use a tab escape sequence to write the following lines

#Use the string formatting method to display the following:
radius = 10
area = 3.14 * radius ** 2
print ("The area of a circle with radius {} is {} meters square.".format (radius,area))

#Make the following using string formatting methods:
a=8
b=6
print ("{} + {} = ".format (a,b), a+b)
print ("{} - {} = ".format (a,b), a-b)
print ("{} * {} = ".format (a,b), a*b)
print ("{} / {} = ".format (a,b), a/b)
print ("{} % {} = ".format (a,b), a%b)
print ("{} // {} = ".format (a,b), a//b)
print ("{} ** {} = ".format (a,b), a**b)

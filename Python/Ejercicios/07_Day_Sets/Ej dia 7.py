#	# sets
it_companies = {'Facebook', 'Google', 'Microsoft', 'Apple', 'IBM', 'Oracle', 'Amazon'}
A = {19, 22, 24, 20, 25, 26}
B = {19, 22, 20, 25, 26, 24, 28, 27}
age = [22, 19, 24, 25, 26, 24, 25, 24]
#	Exercises: Level 1
#	1. Find the length of the set it_companies
print (len (it_companies))

#	2. Add 'Twitter' to it_companies
it_companies.add ('Twitter')
print(it_companies)

#	3. Insert multiple IT companies at once to the set it_companies
it_companies.update (['Kiwi', 'Tiktok', 'Tesla'])
print(it_companies)

#	4. Remove one of the companies from the set it_companies
it_companies.remove ('Tesla')
print(it_companies)

#	5. What is the difference between remove and discard
#UNO PUEDE DAR ERROR SI EL ITEM NO EXISTE (REMOVE)

#	Exercises: Level 2
#	1. Join A and B
C= A.union (B)
print (A)
print (B)
print (C)
#	2. Find A intersection B
print (A.intersection (B))

#	3. Is A subset of B
print ("A es subset B:",A.issubset (B))

#	4. Are A and B disjoint sets
print ("A is disjoint B:" , A.isdisjoint (B))

#	5. Join A with B and B with A
B.update (A)
A.update (B)
print (A)
print (B)

#	6. What is the symmetric difference between A and B
print (A.difference(B))
print (B.difference(A))

#	7. Delete the sets completely
del A
del B
del C


#	Exercises: Level 3
#	1. Convert the ages to a set and compare the length of the list and the set, which one is bigger?
ages_set = set (age)
print ("El len del set es de {} y el len del list es de {}".format (len(ages_set), len (age)))
print (age)
print (ages_set)
#	2. Explain the difference between the following data types: string, list, tuple and set
#List permite almacenar distintos tipos de datos y ordenados, tuple es como la lista, pero no se puede modificar, y set es cmoo una lista, pero desordenados, el string es un conjunto de caracteres 
#que forman una palabra

#	3. I am a teacher and I love to inspire and teach people. How many unique words have been used in the sentence? Use the split methods and set to get the unique words.
oracion = "I am a teacher and I love to inspire and teach people"
oracion_list = oracion.split ()
oracion_set = set (oracion_list)
print ("La cantidad de palabras  usadas es de:", len(oracion_list))
print ("La cantidad de palabras unicas usadas es de:", len(oracion_set))
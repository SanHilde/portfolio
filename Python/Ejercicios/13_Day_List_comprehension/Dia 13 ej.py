#	1. Filter only negative and zero in the list using list comprehension
numbers = [-4, -3, -2, -1, 0, 2, 4, 6]
negative_zero= [i for i in numbers if i < 1]
print (negative_zero)

#	2. Flatten the following list of lists of lists to a one dimensional list :
list_of_lists =[[[1, 2, 3]], [[4, 5, 6]], [[7, 8, 9]]]
only_list = [i for i in list_of_lists for i in i for i in i]
print (only_list)
#	
#	output
a=[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
#	3. Using list comprehension create the following list of tuples:
#lista_multiplos= [tuple(range(0,11)) for i in range(0,11)]
lista_multiplos= [(i,i**0,i**1,i**2,i**3,i**4,i**5) for i in range(0,11)]
print (lista_multiplos)
#	[(0, 1, 0, 0, 0, 0, 0),
#	(1, 1, 1, 1, 1, 1, 1),
#	(2, 1, 2, 4, 8, 16, 32),
#	(3, 1, 3, 9, 27, 81, 243),
#	(4, 1, 4, 16, 64, 256, 1024),
#	(5, 1, 5, 25, 125, 625, 3125),
#	(6, 1, 6, 36, 216, 1296, 7776),
#	(7, 1, 7, 49, 343, 2401, 16807),
#	(8, 1, 8, 64, 512, 4096, 32768),
#	(9, 1, 9, 81, 729, 6561, 59049),
#	(10, 1, 10, 100, 1000, 10000, 100000)]
#	4. Flatten the following list to a new list:
countries = [[('Finland', 'Helsinki')], [('Sweden', 'Stockholm')], [('Norway', 'Oslo')]]
#list_countries = [list(i) for i in countries for i in i]
list_countries = [[i[0].upper(), i[0][0:3].upper(), i[1].upper()] for i in countries for i in i]
print (list_countries)
#	output:
#	[['FINLAND','FIN', 'HELSINKI'], ['SWEDEN', 'SWE', 'STOCKHOLM'], ['NORWAY', 'NOR', 'OSLO']]
#	5. Change the following list to a list of dictionaries:
countries = [[('Finland', 'Helsinki')], [('Sweden', 'Stockholm')], [('Norway', 'Oslo')]]
#	output:
#	[{'country': 'FINLAND', 'city': 'HELSINKI'},
#	{'country': 'SWEDEN', 'city': 'STOCKHOLM'},
#	{'country': 'NORWAY', 'city': 'OSLO'}]
list_countries_two = [{'country': i[0].upper(), 'city:': i[1].upper()} for i in countries for i in i]
print (list_countries_two)
#	6. Change the following list of lists to a list of concatenated strings:
names = [[('Asabeneh', 'Yetayeh')], [('David', 'Smith')], [('Donald', 'Trump')], [('Bill', 'Gates')]]
list_names = list ()
[list_names.append (i[0]+' '+i[1]) for i in names for i in i]
print (list_names)
#	output
#	['Asabeneh Yetaeyeh', 'David Smith', 'Donald Trump', 'Bill Gates']

#	7. Write a lambda function which can solve a slope or y-intercept of linear functions.

#	1. Declare an empty list
empty_lst = list()
#	2. Declare a list with more than 5 items
lst = list (['banana', 'manzana', 'durazno', 'limon', 'frutilla'])
#	3. Find the length of your list
print (len(lst))

#	4. Get the first item, the middle item and the last item of the list
print (lst [0], lst[int(len(lst)/2)], lst[len(lst)-1])
#	5. Declare a list called mixed_data_types, put your(name, age, height, marital status, address)
mixed_data_types = list (['Santiago', '27', '83 kg', 'soltero', 'Italia 946' ])

#	6. Declare a list variable named it_companies and assign initial values Facebook, Google, Microsoft, Apple, IBM, Oracle and Amazon.
it_companies = list (['Facebook', 'Google', 'Microsoft', 'Apple', 'IBM', 'Oracle', 'Amazon'])
#	7. Print the list using print()
print (it_companies)

#	8. Print the number of companies in the list
print (len (it_companies))

#	9. Print the first, middle and last company
print (it_companies [0], it_companies[int(len(it_companies)/2)], it_companies[len(it_companies)-1])

#	10. Print the list after modifying one of the companies
it_companies [3] = 'Volkswagen'
print (it_companies)

#	11. Add an IT company to it_companies
it_companies.append ("IT company")
print (it_companies)

#	12. Insert an IT company in the middle of the companies list
it_companies.insert (int(len(it_companies)/2), "It company 2")
print (it_companies)

#	13. Change one of the it_companies names to uppercase (IBM excluded!)
print ( it_companies[0].upper())

#	14. Join the it_companies with a string '#;  '
print ("#; ".join (it_companies))

#	15. Check if a certain company exists in the it_companies list.
print (0 <= it_companies.index ('Google'))

#	16. Sort the list using sort() method
it_companies.sort()
print (it_companies)

#	17. Reverse the list in descending order using reverse() method
it_companies.sort(reverse=True)
print (it_companies)

#	18. Slice out the first 3 companies from the list
print (it_companies[3:])

#	19. Slice out the last 3 companies from the list
print (it_companies[:-3])

#	20. Slice out the middle IT company or companies from the list
medio = int(len(it_companies)/2)
print (it_companies[0:medio])
print (it_companies [medio+1:])

#	21. Remove the first IT company from the list
print (it_companies)
it_companies.pop(0)
print (it_companies)

#	22. Remove the middle IT company or companies from the list
medio = int(len(it_companies)/2)
it_companies.pop(medio-1)
print (it_companies)

#	23. Remove the last IT company from the list
it_companies.pop(len(it_companies)-1)
print (it_companies)

#	24. Remove all IT companies from the list
it_companies.clear ()
print (it_companies)

#	25. Destroy the IT companies list
del it_companies

#	26. Join the following lists:
front_end = ['HTML', 'CSS', 'JS', 'React', 'Redux']
back_end = ['Node','Express', 'MongoDB']
lista_completa = front_end+back_end
print (lista_completa)

#	27. After joining the lists in question 26. Copy the joined list and assign it to a variable full_stack. Then insert Python and SQL after Redux.
full_stack = lista_completa.copy ()
print (full_stack)
indice = full_stack.index ('Redux')
full_stack.insert (indice+1, 'SQL')
full_stack.insert (indice+1, 'Python')
print (full_stack)

#	1. The following is a list of 10 students ages:
ages = [19, 22, 19, 24, 20, 25, 26, 24, 25, 24]
#	Sort the list and find the min and max age
ages.sort()
print ("Min age:" , ages[0], " , max age:", ages[len(ages)-1])
print (ages)

#	Add the min age and the max age again to the list
ages.insert (0, ages[0])
ages.append (ages[len(ages)-1])
print (ages)

#	Find the median age (one middle item or two middle items divided by two)
print ("Edad en el medio:", ages[int(len(ages)/2)])

#	Find the average age (sum of all items divided by their number )
a=0
sumatoria=0
while a < len(ages):
    sumatoria = sumatoria + ages[a]
    a= a+1
print ("El promedio de edad es:" , sumatoria/ len(ages))

#	Find the range of the ages (max minus min)
#	Compare the value of (min - average) and (max - average), use abs() method
min = ages[0]
max = ages[len(ages)-1]
promedio = sumatoria/ len(ages)
average_min = abs(min-promedio)
average_max = abs (max-promedio)
print ("Min - average ={} y max - average={}".format (average_min, average_max))

#	1. Find the middle country(ies) in the countries list
countries = [
  'Afghanistan',
  'Albania',
  'Algeria',
  'Andorra',
  'Angola',
  'Antigua and Barbuda',
  'Argentina',
  'Armenia',
  'Australia',
  'Austria',
  'Azerbaijan',
  'Bahamas',
  'Bahrain',
  'Bangladesh',
  'Barbados',
  'Belarus',
  'Belgium',
  'Belize',
  'Benin',
  'Bhutan',
  'Bolivia',
  'Bosnia and Herzegovina',
  'Botswana',
  'Brazil',
  'Brunei',
  'Bulgaria',
  'Burkina Faso',
  'Burundi',
  'Cambodia',
  'Cameroon',
  'Canada',
  'Cape Verde',
  'Central African Republic',
  'Chad',
  'Chile',
  'China',
  'Colombi',
  'Comoros',
  'Congo (Brazzaville)',
  'Congo',
  'Costa Rica',
  "Cote d'Ivoire",
  'Croatia',
  'Cuba',
  'Cyprus',
  'Czech Republic',
  'Denmark',
  'Djibouti',
  'Dominica',
  'Dominican Republic',
  'East Timor (Timor Timur)',
  'Ecuador',
  'Egypt',
  'El Salvador',
  'Equatorial Guinea',
  'Eritrea',
  'Estonia',
  'Ethiopia',
  'Fiji',
  'Finland',
  'France',
  'Gabon',
  'Gambia, The',
  'Georgia',
  'Germany',
  'Ghana',
  'Greece',
  'Grenada',
  'Guatemala',
  'Guinea',
  'Guinea-Bissau',
  'Guyana',
  'Haiti',
  'Honduras',
  'Hungary',
  'Iceland',
  'India',
  'Indonesia',
  'Iran',
  'Iraq',
  'Ireland',
  'Israel',
  'Italy',
  'Jamaica',
  'Japan',
  'Jordan',
  'Kazakhstan',
  'Kenya',
  'Kiribati',
  'Korea, North',
  'Korea, South',
  'Kuwait',
  'Kyrgyzstan',
  'Laos',
  'Latvia',
  'Lebanon',
  'Lesotho',
  'Liberia',
  'Libya',
  'Liechtenstein',
  'Lithuania',
  'Luxembourg',
  'Macedonia',
  'Madagascar',
  'Malawi',
  'Malaysia',
  'Maldives',
  'Mali',
  'Malta',
  'Marshall Islands',
  'Mauritania',
  'Mauritius',
  'Mexico',
  'Micronesia',
  'Moldova',
  'Monaco',
  'Mongolia',
  'Morocco',
  'Mozambique',
  'Myanmar',
  'Namibia',
  'Nauru',
  'Nepal',
  'Netherlands',
  'New Zealand',
  'Nicaragua',
  'Niger',
  'Nigeria',
  'Norway',
  'Oman',
  'Pakistan',
  'Palau',
  'Panama',
  'Papua New Guinea',
  'Paraguay',
  'Peru',
  'Philippines',
  'Poland',
  'Portugal',
  'Qatar',
  'Romania',
  'Russia',
  'Rwanda',
  'Saint Kitts and Nevis',
  'Saint Lucia',
  'Saint Vincent',
  'Samoa',
  'San Marino',
  'Sao Tome and Principe',
  'Saudi Arabia',
  'Senegal',
  'Serbia and Montenegro',
  'Seychelles',
  'Sierra Leone',
  'Singapore',
  'Slovakia',
  'Slovenia',
  'Solomon Islands',
  'Somalia',
  'South Africa',
  'Spain',
  'Sri Lanka',
  'Sudan',
  'Suriname',
  'Swaziland',
  'Sweden',
  'Switzerland',
  'Syria',
  'Taiwan',
  'Tajikistan',
  'Tanzania',
  'Thailand',
  'Togo',
  'Tonga',
  'Trinidad and Tobago',
  'Tunisia',
  'Turkey',
  'Turkmenistan',
  'Tuvalu',
  'Uganda',
  'Ukraine',
  'United Arab Emirates',
  'United Kingdom',
  'United States',
  'Uruguay',
  'Uzbekistan',
  'Vanuatu',
  'Vatican City',
  'Venezuela',
  'Vietnam',
  'Yemen',
  'Zambia',
  'Zimbabwe',
]
cant_paises= len(countries)/2
print (cant_paises)
print(int(cant_paises+0.5))

if (len(countries)%2==1):
    print ("Pais del medio:", countries[int(cant_paises+0.5-1)])
else:
    print ("Paises del medio: {} y {}".format (countries[int(cant_paises)],countries[int(cant_paises)+1] ))

#	2. Divide the countries list into two equal lists if it is even if not one more country for the first half.
list_one = list.copy (countries[0:int(cant_paises)+1])
list_two = list.copy (countries[int(cant_paises)+1:])
print (list_one)
print (list_two)


#	3. ['China', 'Russia', 'USA', 'Finland', 'Sweden', 'Norway', 'Denmark']. Unpack the first three countries and the rest as scandic countries.
list_general = ['China', 'Russia', 'USA', 'Finland', 'Sweden', 'Norway', 'Denmark']
list_scandic = list.copy (list_general[3:])
print (list_scandic)



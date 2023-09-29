#	Exercises: Level 1
#	1. Create an empty tuple
tuple_empy = tuple ()

#	2. Create a tuple containing names of your sisters and your brothers (imaginary siblings are fine)
tuple_hermanos =  ('Santiago', 'Martin')
tuple_hermanas =  ('Ximena', 'Julieta')

#	3. Join brothers and sisters tuples and assign it to siblings
tuple_hermanxs = tuple_hermanas+tuple_hermanos
#	4. How many siblings do you have?
print (len (tuple_hermanxs))

#	5. Modify the siblings tuple and add the name of your father and mother and assign it to family_members
family_members = ('Gustavo', 'Delia')
family_members = family_members + tuple_hermanxs
print (family_members)

#	Exercises: Level 2

#	1. Unpack siblings and parents from family_members
parents = family_members [0:2]
brothers = family_members [2:6]
print (parents)
print (brothers)

#	2. Create fruits, vegetables and animal products tuples. Join the three tuples and assign it to a variable called food_stuff_tp.
fruits = ('banana', 'manzana', 'durazno', 'frutilla')
vegetable = ('zanahoria', 'lechuga', 'brocoli', 'zapallito')
animal = ('vaca', 'cerdo', 'pescado', 'cordero')
food_stuff_tp= fruits+vegetable+animal
print (food_stuff_tp)

#	3. Change the about food_stuff_tp tuple to a food_stuff_lt list
food_stuff_lt= list (food_stuff_tp)
print (food_stuff_lt)

#	4. Slice out the middle item or items from the food_stuff_tp tuple or food_stuff_lt list.
food_stuff_tp_midle = food_stuff_tp[int(len(food_stuff_tp)/2)]
print (food_stuff_tp_midle)


#	5. Slice out the first three items and the last three items from food_staff_lt list
food_staff_lt_part = food_stuff_lt.copy ()
del food_staff_lt_part [3:(len (food_stuff_lt)-3)] 
print (food_staff_lt_part)


#	6. Delete the food_staff_tp tuple completely
del food_stuff_tp

#	7. Check if an item exists in tuple:
#	Check if 'Estonia' is a nordic country
#	Check if 'Iceland' is a nordic country
nordic_countries = ('Denmark', 'Finland','Iceland', 'Norway', 'Sweden')
print ('Estonia' in nordic_countries)
print ('Iceland' in nordic_countries)

## Exercise 1 - Hurricane

The Saffir-Simpson Hurricane Scale classified hurricanes into 5 categories numbered 1 through to 5 based on the observed wind speed. There is also a sixth category for situations where the wind speed is less than the lower threshold speed for category 1.

In this exercise you will write an application that asks the user to enter a non-negative integer which represents the observed wind speed, and displays a message which informs the user which category applies.

The following table sets out the hurricane levels and the message which should be displayed for each level:

252 or above – "cataclysmic damage will occur"
209 to 251 km/h – "catastrophic damage will occur"
178 to 208 km/h – "devastating damage will occur"
154 to 177 km/h – "extremely dangerous winds will occur"
119 to 153 km/h – "very dangerous winds will produce some damage"
0 to 118 km/h – "the damage from winds is minimal"
Notes:

The skeleton code will get wind speed from the user and store the value in an integral variable named windSpeed.
A variable called message of type string, has been declared but not initialised.
Your task is to insert instructions which assign a suitable value to message, based on the wind speed obtained from the user.
After you have assigned a value to message, skeleton code will emit the results to the standard output stream.
All input and output is carried out by the supplied skeleton code.
Do not attempt to rewrite the supplied code.
Do not perform any input or output operations oher than those which are already supplied in the skeleton.
In this exercise, all supplied input text will consist of suitable numeric strings.

Tests will cover the following categories:

Wind speed exactly equal to the lower bound for each category.
Wind speed between the bounds for each category other than 5.
Wind speed exactly equal to the upper bound for each category other than 5).
Wind speed in excess of the lower bound for category 5.
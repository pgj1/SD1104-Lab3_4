LAB 3.4

2. Practice writing RegEx on https://regex101.com/. 

Copy the following block of text into the Test String box on regex101.com, and then write out these RegEx expressions.

Test String:
Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….

2a. Find all of the occurrences of the letter ‘d’ or ‘e’‘
REGEX [d-e]

2b. Find all of the occurrences of the letter ‘d’ or’ e’, followed by another ‘d’
REGEX [d-e][*d]

2c. Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again
REGEX [a][a-z][a]

2d. Find all of the words that start with the letter “p”
REGEX [ ][p][a-z]*

2e. Find all of the words that end with the letter e
REGEX [a-z]*[e][ ]

2f. Find all of the capital letters
REGEX [A-Z]

3. On Regex101.com, click on the Tools > Code Generator and then choose C#. You will be given the C# code for the RegEx. Study the code created by the tool.

Copy the Code from Regex101.com into a new C# project, upload it GitHub, and turn in your GitHub link to your instructor.

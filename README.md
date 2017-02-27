# virtual-pet
Virtual Pet - 2nd Project for We Can Code IT 
## Project Requirements
Using C# make a virtual pet console program. Your version of a Tamagotchi or DigiPet!

### Required Tasks

- [ ] VirtualPet class
  - [ ] Properties (at least three)
  - [ ] Methods (at least three)

### Stretch Tasks (optional)

- [ ] Give the pet the ability to take care of some of its own needs
- [ ] A visual representation of the pet
- [ ] Alternative interfaces

### My Result

I created a virtual pet called Fuzzy the Falcon. He's a funny looking bird.

                    
                      \/
                    __.---;_
                  .'  './'0)',\
                  |o)  |     | ';
                  :'--; \.__/'   ;
                   ;.' (         |
              __.-'   _.)        |
          -===-----'''           | 
                 ;^;         .  ^+^^
               ;^  :         :       ^;
                \  {          :_     /
                 ^'-;          :'--'^
                    ,,____,,-'

                 __   _______   ______
       ============(((=======(((==============

Fuzzy has four properties:
- Hunger
- Excitement
- Energy
- Dependency

Fuzzy has six user callable methods:
- Fly
- Play
- Attack
- Tick
- Go Home

Calling some of the methods will cause the property values to change. For instance, if Fuzzy flies, excitement and hunger levels will rise, but energy levels will fall.
All methods will update some property with the exception of the Go Home method. This method will end the program.

The Tick method will allow Fuzzy to auto-manage and choose a method that will correct whatever property needs attention.
If Fuzzy is hungry, he will go hunting to get food and replenish energy. The Tick method covers one of the stretch goals above.

Another stretch task was to provide a visual representation of my pet. The above ASCII art was found on [chris.com](http://www.chris.com/ascii/index.php?art=animals/birds%20(land)).
Finally, I designed a feedback interface that displays each property's current value as an integer and as well as a horizontal meter that ranges from 1 to 10.


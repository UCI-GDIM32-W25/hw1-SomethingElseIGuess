[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Homework 1 Activity

1) How would you describe this game world in objects?
- The Player Character
- The Plants placed by the Player
- The UI: Seeds Planted UI, Seeds Remaining UI

2) What attributes and actions do these objects have?
- The Player Character: Movement around the playfield with the WASD keys, and able to plant seeds with the Space key.
- The Plants: Able to be planted by the Player Character, appearing on the playfield where the Player placed them.
- The UI: The Seeds Planted UI increases during the game, the Seeds Remaining UI decreases during the game. 

3) How do these objects act on or affect each other?
- The Player Character: Able to place plants on the playfield with the space key.
- The Plants: Able to be placed by the Player Character on the playfield.
- The UI: The Seeds Planted UI increases whenever the player places a plant, while the Seeds Remaining UI decreases whenever the player places a plant. Seeds Planted caps out at 5, no matter what. Seeds Remaining always ends up at 0.

My plan for creating the game:
- Establish how the game should look when it starts with private void Start, seeding the number of seeds planted to zero and the number of seeds left to five.
- Implement the keybinds for moving the character, WASD, with if(Input.GetKey(KeyCode.?)) and _playerTransform.Translate, the same command I used for a project in GDIM31.
- Implement the key bind for placing a plant with the space bar, using the same Input detection command as the previous in order to force the program to active the seed planting function. 
- Have the plant be created by making a plant prefab object in the editor, and then instantiating it in the code beneath the seed planting function. In conjunction, add a command that decreases the number of seeds remaining and increases the number of seeds planted whenever the space bar is pressed, updating the UI.
- Create the UI by adding the name of the counter to a string with the number of seeds either remaining or already planted, updated every time the seed planting function is called.
- Succeed hopefully.

## Devlog
This was a pretty good introductory project that I understood fairly well. As I stated in my plan, first step of business was organizing how the game would start, setting the number of seeds left to the number of seeds given (set in the editor to five) and the number of seeds planted to zero. Then I used float to set the horizontal and vertical input access, and basically copied over some code from a previous project to give the character horizontal and vertical movement with WASD. However, of course, I needed to add the input for space bar, which would call the function PlantSeed, done the same way as the rest of my "Input.GetKey".

That function was then expanded the public void PlantSeed area, where I made an if statement that stated that if the number of seeds were above zero and the space bar was pressed, the Game Object, plant prefab, would be instantiated and the UI would be updated. Basically I followed my plan beat for beat, but of course things didn't completely work out the right way. 
For example, upon first testing, my character would move but they wouldn't plant seeds no matter what I did, which ended up being due to me using the "<" instead of ">" meaning the seeds would only be called if I somehow had less then 0 seeds. Even after fixing this, whenever I would press the spacebar, the player would place all five plants at the exact same time instead of letting you pick where you place them. I ended up fixing this by changing the spacebar's input from "Input.GetKey" to "Input.GetKeyDown" since now the function would only activate individually upon pressing the key down. 

From there things were mostly smooth sailing, as the UI functioned relatively well upon being coded and everything fit together. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Great job on writing a plan down and connecting it to how you actually built the project! I look forward to seeing how the structure of your plans evolve over the next few Devlogs.

> - Succeed hopefully.

Always an important step in the plan. LOL

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above,. Also, you can remove the prompt text. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).

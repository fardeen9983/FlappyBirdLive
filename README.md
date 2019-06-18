# FlappyBirdLive
## New Project
1. Create a new Unity 2D project
2. Import all Sprites and Fonts
3. Modify Bird sprite:
    * Change sprite mode to Multiple
    * Slice Sprite into three parts
4. Add the Bird sprite zero, the Grass and sky sprites to Scene
5. Make the Sky sprite as child to Grass and rename it to Ground so that both of them move together
5. Create Foreground, Background and Midground sorting layers
6. Assign sorting layers :
    * Foreground - Bird, Ground
    * Background - Sky

## Adding Physics
1. Add RigidBody2D and Polygon collider to the Bird sprite
2. Add BoxCollider to Ground sprite

The Bird will now collide to the ground

Now create a New Script and add it to the Bird object:
1. Keep track of the birds state : Either dead or alive
2. Add upward force on mouse event if bird is alive. 

## Adding animation
1. Open the Animations and Animator panels from Window option
2. Select Bird sprite and create 3 Animations
    * Idle
    * Flap
    * Die
 3. For all 3 animations assign appropriate sprite properties from the sliced sprite
 
 In the Animator window :
 1. Create two Triggers
    * Flap
    * Die
 2. Create Transition from Idle to Die. In the transition
    * Disable Has Exit time
    * Assign Die trigger as condition
 3. Create Transition from Idle to Flap. In the transition
    * Disable Has Exit time
    * Assign Flap trigger as condition
 4. Create Transition back from Flap to Idle. In the transition
    * Enable Has Exit time
    * Add no triggers as conditions
 
 Add animation control
 1. Open the script to control the bird
 2. Create reference to Animator component
 3. On mousedown set Flag trigger on animator
 4. On dying set Die trigger on animator
      
## Add UI
1. Create a UI element Text (Automatically adds a Canvas and an Event System)
2. Modify the Text object :
    * Rename to ScoreText
    * Change font size to 32
    * Change font to LuckGuy from assets
    * Set Horizontal and Vertical Overflow to Overflow  
    * Set color to White
    * Align Text to center
    * Align it to bottom center of the Scene
    * Move it upwards by few pixels
    * Add Shadow component and set Effect distance to some value for both X and Y axis
3. Create a similar text object called GameOverText 
    * Align it to below the Top center of the scene 
    * Increase font size to 48
4. Create another Text object named RestartText
    * Set text to "Flap to restart"
    * Align below the GameOver text
    * Set size to 24
5. Disable GameOverText and RestartText on game startup and enable only when Bird dies (on game over )     
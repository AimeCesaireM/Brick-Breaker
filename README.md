# Brickbreaker Game - Unity

This is a classic Brickbreaker game developed using the **Unity game engine** and **C#** for scripting. The game mechanics, user interface, and gameplay features are implemented primarily using **Object-Oriented Programming** principles, leveraging the functions from the **UnityEngine** namespace, and implementing the **MonoBehaviour** base class for handling game logic and interactions.

## Features
- **Breakable Bricks**: Bricks that get destroyed when hit by the ball.
- **Ball Physics**: Realistic bouncing and collision detection.
- **Paddle**: A controllable paddle to bounce the ball back and forth.
- **Game Levels**: Multiple levels with increasing difficulty.
- **Score System**: A scoring system to track the player's progress.
- **Sound Effects**: Audio for ball collisions, brick destruction, and other game events.
- **User Interface**: Menus for starting the game, showing the score, and displaying the game over screen.

## Installation

1. **Clone this repository**:

   ```bash
   git clone https://github.com/AimeCesaireM/Brick-Breaker.git
   ```

2. **Open the project in Unity**:
   - Launch Unity Hub.
   - Click on "Open Project" and select the folder where you cloned this repository.

3. **Run the game**:
   - In the Unity editor, click the "Play" button to start the game.
   - The game should automatically start in the editor view. You can adjust settings or test it within the Unity environment.

## Gameplay

- **Control the paddle**: Use the arrow keys or mouse to control the paddle and keep the ball bouncing.
- **Break the bricks**: The goal is to break all the bricks on the screen by bouncing the ball off your paddle.
- **Score points**: Every brick you break adds to your score.
- **Complete levels**: Clear all the bricks to move on to the next level, where the difficulty increases.

## Code Architecture

### Object-Oriented Programming

The project follows the principles of **Object-Oriented Programming (OOP)**, where the main game components—such as the ball, paddle, and bricks—are represented as objects with defined behaviors and attributes. This makes it easier to manage the different elements of the game and extend the functionality in the future.

### Key Components

- **Ball.cs**: Manages the ball’s movement and collision detection.
- **Paddle.cs**: Controls the paddle's movement and interaction with the ball.
- **Brick.cs**: Defines the behavior of the breakable bricks, including their destruction when hit.
- **GameController.cs**: Handles the main game loop, including the start, end, and level transitions.
- **UIManager.cs**: Manages the user interface elements such as the score display and game over screen.

### Unity-Specific

- **MonoBehaviour**: The game objects are all derived from `MonoBehaviour`, Unity's base class for all scripts that interact with the Unity engine. This allows the game to update and respond to player input, physics, and collisions.

## License

This project is open source and available under the MIT License.

## Acknowledgments

- Unity for providing the game engine and tools for rapid game development.
- Free sound effects and assets used in the game.

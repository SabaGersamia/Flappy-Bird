# Flappy Bird Game

Welcome to my implementation of the **Flappy Bird** game using **C#** and **Windows Forms**. This is a simple clone of the popular game where you control a bird, guiding it between pipes by pressing the space bar to fly and avoid obstacles.

## Table of Contents

- [Features](#features)
- [Gameplay Instructions](#gameplay-instructions)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [How to Play](#how-to-play)
- [Contributing](#contributing)

## Features

- Simple and intuitive gameplay mechanics.
- Increasing difficulty as the game progresses (pipes move faster with higher scores).
- Collision detection between the bird, pipes, and ground.
- Dynamic score display.
- Restart functionality without restarting the entire application.
- Basic UI elements for restarting and exiting the game.
- Help button to show the control instructions.

## Gameplay Instructions

- **Objective**: Fly the bird through the gaps between the pipes without hitting them or the ground.
- **Controls**: 
  - Press the `Space` bar to make the bird fly upwards.
  - Release the `Space` bar to let the bird fall.
  - Avoid the pipes and the ground to keep the bird alive.
- As the score increases, the pipes will move faster, making the game more challenging.

## Technologies Used

- **C#**: Core programming language used for game logic.
- **Windows Forms**: Used to create the graphical user interface (GUI) for the game.
- **Visual Studio**: IDE for building and running the game.

## Installation

1. Clone the repository to your local machine:
    ```bash
    git clone https://github.com/yourusername/FlappyBird-CSharp.git
    ```
2. Open the project in **Visual Studio**.
3. Restore any NuGet packages (if necessary).
4. Build the solution (`Ctrl + Shift + B`).
5. Run the game (`F5`).

## How to Play

1. Press the `Space` bar to make the bird fly.
2. Avoid hitting the pipes or the ground.
3. The game ends if the bird collides with an obstacle or falls below the screen.
4. Press the **Restart** button to play again or the **Exit** button to close the game.
5. Use the **Help** button to view instructions on how to play.

## Contributing

If you'd like to contribute to this project, feel free to submit a pull request or open an issue to suggest improvements or report bugs.

1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

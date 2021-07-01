'use strict';

//The variable that will provide the random number
let secretNumber = Math.trunc(Math.random() * 20) + 1;
//The score variable, that will decrease as the player fails to guess
let scoreNumber = 20;
//The variable to store the highscore
let highScore = 0;

const changeMessage = function (message) {
  document.querySelector('.message').textContent = message;
};
//document.querySelector('.number').textContent = secretNumber;
document.querySelector('.check').addEventListener('click', function () {
  const guess = Number(document.querySelector('.guess').value);
  //When no number is provided
  if (!guess) {
    changeMessage('😢 Dude, provide a number');
  } //When the player wins
  else if (guess === secretNumber) {
    changeMessage('🥳 Correct number!!');
    document.querySelector('body').style.backgroundColor = '#60b347';
    document.querySelector('.number').style.width = '30rem';
    document.querySelector('.number').textContent = secretNumber;
    if (scoreNumber > highScore) {
      highScore = scoreNumber;
      document.querySelector('.highscore').textContent = highScore;
    }
  } //When the player guesses wrong
  else if (guess !== secretNumber) {
    if (scoreNumber > 1) {
      changeMessage(guess > secretNumber ? '☝️ Too High!' : '👇 Too Low!');
      document.querySelector('.score').textContent = scoreNumber -= 1;
    } else {
      changeMessage('😰 GAME OVER!!');
      document.querySelector('.score').textContent = 0;
    }
  }
});
//Reset the game once the again button is pressed
document.querySelector('.again').addEventListener('click', function () {
  scoreNumber = 20;
  secretNumber = Math.trunc(Math.random() * 20) + 1;
  document.querySelector('body').style.backgroundColor = '#222';
  changeMessage('Start guessing...');
  document.querySelector('.score').textContent = scoreNumber;
  document.querySelector('.number').textContent = '?';
  document.querySelector('.guess').value = '';
  document.querySelector('.number').style.width = '15rem';
});

# Bug List - Final Project

Alfred Ågren
Beat Em Up

Put this file in `Assets/Documentation/`. Required at Beta (Wednesday Nov 11).
Write a bug down the moment you see it. Fix the worst ones first.

## How to Write a Bug
What I did -> What happened -> What I expected.
> Example: "Pressed Esc during the last 10 seconds -> the timer kept counting -> the timer should stop when I pause."

## Fix Order
1. Stops the game (crash, can't start, can't win or lose, stuck)
2. Breaks a G requirement
3. Confuses a tester
4. Polish

Happens every time, or in the first 30 seconds? Move it up one level.
Test every fix in the Windows build, not just in the editor.

## My Bugs

| # | What I did -> What happened -> What I expected | How often | Found by | Order (1-4) | Status |
|---|---|---|---|---|---|
| 1 | I changed the enemy size and porportion | The flip script that makes the enemies always flip toward the player suddenly made the enemy teleport behind the player when getting close | I expected it to work as intended with normal collision | Every time | Me | 3 | Fixed (Hurtbox was accidentally moved off center) |
| 2 | Pressed A and D at the same time | It flips the sprite, but only at one direction | I thought it would stay completely still | Every time | Me | 3 | Was too tricky to fix in time, the bug unfortunately shipped
| 3 | Enemies attacked close within each other | They killed each other on hit | Every time | Me | 3 | Fixed. I created seperate "enemy hitboxes" that only interacts with the player

How often: every time / sometimes / once. Found by: me / a tester.
Status: Fixed / Will fix / Won't fix (because ___).
"Won't fix" is a real answer. Studios ship with known bugs every time. Just write why.

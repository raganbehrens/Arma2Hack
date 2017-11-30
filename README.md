My first hack. Read data from the process memory to show player locations on a map. Wrote to memory to change some values such as my location (teleport), fatigue, recoil, etc.
Made in 2013 and I continued to work on it until it was made obsolete by a game update. The update makes the game run in kernel mode so the memory was no longer accessible from user space (a kernel mode driver could address this problem).
I used a similar hack (I can no longer find the source) as reference.

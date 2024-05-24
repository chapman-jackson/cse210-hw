// CREATIVITY POINTS DESCRIPTION FOR THE GRADER
// There are milestones at 1000, 2500, and 5000 points. 
// A message is displayed to congratulate the user on reaching the milestone.
// When the point counter reached or surpasses 5000 points,
// it resets to 0 so the user can do the milestones again with future goals.
// These milestone messages are found in the public void record event function.

using System;

class Program
{
    static void Main(string[] args)
    {
        
        GoalManager goalManager = new GoalManager(0);
        goalManager.Start();
    }
}
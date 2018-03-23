﻿// This is the Reaction to change the satisfied state
// of a Condition.  The Condition here is a reference
// to one on the AllConditions asset.  That means by
// changing the Condition here, the global game
// Condition will change.  Since Reaction decisions
// are made based on Conditions, the change must be
// immediate and therefore this is a Reaction rather
// than a DelayedReaction.
public class ConditionReaction : Reaction
{
    public Condition.ConditionName condition;
    public bool satisfied;
	protected override void ImmediateReaction()
	{
        AllConditions.GetCondition(condition).satisfied = satisfied;
	}
}

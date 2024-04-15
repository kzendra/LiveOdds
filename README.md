# LiveOdds
Simple live odds library contains a list of active matches currently being played out inside LiveMatches type,
where caller can add active match, update a score, finish a match or get a summary of active matches.


## Requirements

This module requires .net 8 to be installed.


During the first part of work on this I steered in a wrong direction influenced by a fact that during my career I was 
working on business applications that required me to save data. And my mind locked me in a direction that this is a domain module. 
which should have one AggregateRoot exposed and all entities behind it should be protected from external tampering. 
After realising my mistake, I did some refactory. 

Regarding the business requirements i have questions:
1. Should it be possible to decrease the score?
2. Should it be possible to have the same team appear in two active games?
3. Is it possible to have negative score (I have used uint, so in library it's blocked, but I do not know if that is right)?
4. When match is finished, should it be stored somewhere else for historical reasons? 
	Or just be marked as finished and not displayed on scoreboard (would require new bool property and a filter on summary)?
5. I would approach score updating in a way that home team score can updated separately from the away team score. 
	This would probably be a base class and would be implemented for a different type of sports, which would then have each own 
	validations to update score...
	
I was seconds away from implementing summary as a list of strings as I worked with cash registers, 
that had customer displays connected, in the past...

using System;
using COPStarter;
using System.Collections.Generic;
using System.IO;

namespace Console
{
	class Program
	{
		static void Main(string[] args)
		{

			COPMethods cs = new COPMethods();

			List<string> lyrics = new List<string>();
			List<string> cutdownLyrics = new List<string>();

			lyrics.Add("Twinkle, twinkle, little star How I wonder what you are Up above the world so high Like a diamond in the sky");
			lyrics.Add("Today is gonna be the day That they're gonna throw it back to you By now you should've somehow Realized what you gotta do I don't believe that anybody Feels the way I do, about you now");
			lyrics.Add("Mama, just killed a man Put a gun against his head Pulled my trigger, now he's dead Mama, life had just begun But now I've gone and thrown it all away");
			lyrics.Add("Everybody's doing a brand-new dance, now Come on baby, do the Loco-motion I know you'll get to like it if you give it a chance now Come on baby, do the Loco-motion");
			lyrics.Add("Oh baby, baby Oh baby, baby Oh baby, baby, how was I supposed to know That something wasn't right here? Oh baby, baby, I shouldn't have let you go");
			lyrics.Add("Coming out of my cage And I've been doing just fine Gotta gotta be down Because I want it all It started out with a kiss How did it end up like this It was only a kiss, it was only a kiss");
			lyrics.Add("Yo, I'll tell you what I want, what I really, really want So tell me what you want, what you really, really want I'll tell you what I want, what I really, really want So tell me what you want, what you really, really want I wanna, ha I wanna, ha I wanna, ha I wanna, ha I wanna really, really, really wanna zigazig ah");
			lyrics.Add("I'm the trouble starter, punkin' instigator I'm the fear addicted, a danger illustrated I'm a firestarter, twisted firestarter You're a firestarter, twisted firestarter I'm a firestarter, twisted firestarter");
			lyrics.Add("They tried to make me go to rehab But I said, No, no, no Yes, I've been black But when I come back, you'll know, know, know I ain't got the time And if my daddy thinks I'm fine  He's tried to make me go to rehab I won't go, go, go");
			lyrics.Add("City dweller, successful fella thought to himself Oops I've got a lot of money Caught in a rat race terminally I'm a professional cynic but my heart's not in it I'm payin' the price of livin' life at the limit Caught up in the century's anxiety Yes, it preys on him He's gettin' thin, try the simple life"); 			lyrics.Add("");
			lyrics.Add("I'll sing myself to sleep A song from the darkest hour Secrets I can't keep Inside of the day Swing from high to deep Extremes of sweet and sour Hope that God exists I hope I pray"); 
			lyrics.Add("Happy talk keep talkin' happy talk Talk about things you'd like to do. You gotta have a dream if you don't have a dream How you gonna have a dream come true Talk about a moon floatin' in the sky");

			foreach (var item in lyrics)
			{
				cutdownLyrics.Add(cs.convertLyrics(item));
			}

			if (cutdownLyrics.Count>0)
			{
				//yay
			}


		}
	}
}

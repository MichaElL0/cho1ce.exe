using System;
using System.Threading;

namespace cho1ce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "cho1ce.exe";
            Console.WindowHeight = 30;
            Console.WindowWidth = 145;
            //Checked

            
            First();


        }

        public static void Text(string str)
        {
            foreach (char character in str)
            {
                Console.Write(character);
                Thread.Sleep(50);
            }
        }

        public static void First()
        {
            string choice;

            Text("52376: William, is that you? What happened, why didn't you come to the meeting point? You know what happened to the rest, did they survive? Wheredid you get this program from?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Thread.Sleep(1000);
            Text("L74x9: Hello Tom. No, I'm not your friend William, I'm a Homeland Security Agent or just a very dedicated Party worker, but I won't tell you\nanything else, but you can call me 'Agent'.\n" + "We'll talk about your friends a little later.\n" + "To answer the last question: cho1ce.exe is a text messenger, made for the purpose of quick communication between agents.\n" + "This program is no longer in use, but it is simple and useful, in some situations like these, to communicate with someone very quickly.\n" + "I know you thought about disabling the program, but I advise you not to.\n" + "The consequences will be much worse than you imagine.\n" + "Your girlfriend or family wouldn't want to get tickets to our best work camps.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) What happened to my friends?\n2) Why should I talk to you? I did not do anything.\n3) What is this 'tickets to our best work camps'?\n52376: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("L74x9: As I told you, Tom. We'll talk about your friends later.\nBe patient, it will pay off.");
                    Thread.Sleep(2000);
                    Second();
                    break;
                case "2":
                    Console.WriteLine(" ");
                    Text("L74x9: It is probably clear that if you refuse to talk to me, you will face a greater punishment than what you did, and I am sure you did.\nYou don't have to pretend in front of me.");
                    Thread.Sleep(2000);
                    Second();
                    break;
                case "3":
                    Console.WriteLine(" ");
                    Text("L74x9: Oh Tom. You're not stupid. The stupid person couldn't do what you did.\nTherefore, you know exactly what it means.");
                    Thread.Sleep(2000);
                    Second();
                    break;

                default:
                    NoneAnswer();
                    First();
                    break;
            }
            //Checked

        }

        public static void Second()
        {
            Console.Clear();

            string choice;

            Text("L74x9: All right, Tom. Now describe to me what happened on September 1 at 5:00 pm so that we have the same picture of events.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Thread.Sleep(1000);
            Text("52376: Agent, I can't tell you about something I haven't attended, but I'll try to tell you what I've heard from others.\nSo on September 1, exactly at 5:00 PM, 2 bombs exploded in the Statesland Capitol.\nApparently, a group of friends was planning an attack and one of them who knows chemistry and physics did it and, together with friends, planted it in the Statesland Capitol as part of the revolution in the country.\nI heard there were supposed to be 5 bombs, but only two fired, and as for the bombers, their location is unknown.\nImmediately after the attack, riots began in the streets of the capital and several more important cities.\nIt is said that several thousand Protestants and several hundred policemen have already died.\nI personally do not support the actions of those terrorists who are defiant of our Statesland Liberated Party.\nI believe that the Party is managing our wonderful Liberated Republic of Statesland very well.\nThis is what I know, Agent.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Thread.Sleep(2000);
            Text("L74x9: Tom, you are very modest but also dishonest.\nYou had a huge share in these attacks, after all, it was you who made those bombs which, as you mentioned, did not explode all of them,\nbut you are only 20 years old, anyone can make a mistake.\nFor the person who was there and detonated the bomb, you gave really little detail.\nYou're trying to lie to me and tell me that you only heard what happened but you know what happened.\nYou certainly haven't forgotten it.\nHow can you forget the death of almost 150 people.\nTom, let me be clear.\nIf you give up now and tell me your location, the Party will show you mercy and you will not be sentenced to more than 15 years in prison, and\nyour loved ones will be safe.\nThis is your best offer.\nIt won't be better.\nIt's like Tom, you give yourself to the Party voluntarily and show it the respect and humility it deserves, or won't you appreciate our offer?\n\n");
            Text("1) Okay, just promise that my loved ones will be okay.\n2) As I mentioned, Agent, I did not do this attack and I have nothing to do with it.\n52376: ");


            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("L74x9: Of course, Tom, the Party never lies. Thank you, Tom, for the right decision.");
                    Thread.Sleep(2000);
                    Ending4();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("L74x9: Then let's continue our conversation. It was your best chance. Now it will only get worse.");
                    Thread.Sleep(2000);
                    Third();
                    break;

                default:
                    NoneAnswer();
                    Second();
                    break;

            }
            //Checked
        }

        public static void Third()
        {
            Console.Clear();

            string choice;

            Text("L74x9: Tell me, Tom, how did you make those bombs? How a 20-year-old, just out of high school, made bombs capable of blowing up technically the\nentire Statesland Capitol.\nThe building is quite large and two bombs made by a high school student blew up half of the building.\nHas anyone helped you?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) Anyone could make these bombs. It is not that difficult with the help of the Internet.\n2) You know how to make them, don't you?\n3) As a decent citizen, I have no idea how to make bombs.\n52376: ");


            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("Anyone could make these bombs. It is not that difficult with the help of the Internet.\nJust search and you will find what you are looking for.\nAt school, it is enough to listen and then experiment at home.\nKeep trying until you succeed.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: Tom, you are very modest, but that's enough. You are persistent and patient, it definitely helped.\nNot everyone could make a bomb.\nThe bomb is made to kill.\nNo one with good intentions would do it.\nBut, unfortunately, there are dysfunctional individuals that must be stopped because they can harm the Party and the people, and we cannot allow that.\nWe will also have to limit lessons and material in chemistry and physics in schools.\nThank you, Tom, for the answer.");
                    Thread.Sleep(2000);
                    Four();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("You know how to make them, don't you?\nAfter all, the Party is constantly bombing Asia, constantly blowing up bombs in our country and telling people that they are terrorists from Asiaor Eastern Europe who we should kill.\nThe party knows well how to make them.");
                    Console.WriteLine(" ");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Text("L74x9: Tom, I just want to know how and why.\nRegarding the 'bombing', the Party is fighting terrorism in Asia and we are not bombing entire cities.\nThe party kills terrorists, not civilians like you.\nYour accusations against the Party that we are killing our own citizens are punishable and shameful.\nPeople are sent to labor camps for such opinions, but you will face a worse punishment.\nI promise.");
                    Thread.Sleep(2000);
                    Four();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("As a decent citizen, I have no idea how to make bombs.\nWhy would I do them, I love our country.\nBesides, even if someone wanted to do them, he could not, because after searchimg even the word 'bomb' within 30 minutes, a few agents like you\nwould appear in front of my house.\nRight?");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: You're right, Tom.\nWe monitor all searches to prevent future attacks and actions to the detriment of the Party.\nI also understand that you are still trying to deceive me that you are not the terrorist who killed innocent people working in the government.\nI hope you stop and we can only talk about the truth.\nJust like two citizens telling each other the truth, and only truth.");
                    Thread.Sleep(2000);
                    Four();
                    break;

                default:
                    NoneAnswer();
                    Third();
                    break;

            }
        }

        public static void Four()
        {
            Console.Clear();

            string choice;

            Text("L74x9: Next question Tom. Very simple one.\nAnd I hope you will it them quickly and succinctly.\nWhy did you make these bombs?\nWhat led you to intentionally and deliberately kill hundreds of people?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) I wanted to make a difference, Agent. I wanted it to be better.\n2) Why did I make them? I made them because I hate the Party and our president and this goddamn country.\n3) People have different reasons. Personal and more general.\n52367: ");


            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("I wanted to make a difference, Agent.\nI wanted it to be better.\nTo make it easier. But now I'm not so sure if I really did something.\nDid I fix anything, or maybe I just broke it even more.\nHowever, I still hope that my actions will give some impetus to something greater.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: Tom, we all want to make a difference, make our wonderful country better.\nThe party and our president have been doing this for 20 years.\nThey change our lives for the better.\nBy harming the Party, you will only harm yourself and others.\nYour actions will surely give something impetus.\nAfter your coup, everyday life will change.\nWe will try to correct our error and prevent such situations from happening in the future.\nTherefore, your actions must have spurred something on.\nThank you, Tom, for your sincere reply.");
                    Thread.Sleep(2000);
                    Five();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("Why did I make them? I made them because I hate the Party and our president and this goddamn country.\nWe live in a prison.\nAll our messages and conversations are eavesdropped and recorded.\nThere are cameras everywhere.\nNothing bad can be said about the Party because everything is marked as untrue.\nYou even fake the history.\nYou tell people that you invented most of the things in the world.\nYou tell them that it is very good in our country, while you have to queue for hours for bread, and the bread itself is dry and hard.\nYou are monstrous.\nI wanted to help others escape from this prison.\nGive people freedom. Give them hope for a better tomorrow.\nDid I reply quickly and succinctly enough?");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: You wrote a little. Hope you got it all out.\nEvery word you wrote is not true.\nThere is no evidence of this.\nWe do not live in a prison, but in the greatest country in the world.\nFree from wars and sorrow.\nFree from crime and hunger.\nFree from disputes and quarrels.\nFull of friendship and joy.\nFull of food and prosperity.\nSome people like you just don't appreciate it.\nYou, WANT to do something and we DO it.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("52376: There is no evidence for anything I said because you censor everything and change history as the Party wants.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: Tom, you know that's not true. Don't get manipulated by others.");
                    Thread.Sleep(2000);
                    Five();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("People have different reasons.\nPersonal and more general.\nI wanted to act. And I did it.\nPeople die every day for such trivial reasons.\nWhy not die for something greater?\nWhy not write down on the pages of history.\nUnless the Party changes this history.\nBut then I wasn't thinking, I was just acting.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: The party does not change history, it only updates it.\nUnlike you, the Party plans and always tries to do good for its citizens and does not make hasty decisions.\nThe Party works only in the interests of the people.");
                    Thread.Sleep(2000);
                    Five();
                    break;

                default:
                    NoneAnswer();
                    Four();
                    break;

            }
        }

        public static void Five()
        {
            Console.Clear();

            string choice;

            Text("L74x9: Next question, Tom.\nI prepared a bit for this conversation and looked for things related to you.\nAn interesting thing I noticed is that you hardly ever communicated on the internet.\nNo social media or forums.\nNone.\nWhy doesn't a 20-year-old use our great technology, the internet, to use social media?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) I didn't like being on the internet.\n2) As you know, everything on the internet is recorded and monitored.\n3) I preferred to spend time with my friends as long as I could.\n52367: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("I didn't like being on the internet because you could say I'm not your typical 20 year old.\nBesides, there is nothing there but lies and propaganda.\nOn every corner.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: You're right Tom.\nYou're not a typical '20 year old'.\nA typical 20-year-old wouldn't bomb and kill dozens of innocent people with it.\nThe typical 20 year old would also know that the internet is free from lies and there is only truth there and no propaganda.\nThe party tries to keep social media free from politics.\nBut maybe you don't understand it because you're blinded by lies.");
                    Thread.Sleep(2000);
                    Six();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("As you know, everything on the internet is recorded and monitored.\nThere is no privacy at all.\nOne must behave according to the Code of Freedom and Justice drawn up by the party.\nActually, in real life you have to follow it too, but it's a little easier there, and on the internet it's impossible to have your own opinion\nand express it without accusing you of lying.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: The Code of Freedom and Justice must always be followed.\nIt is our benchmark of what must and cannot be done, Tom.\nThis is a very important document drawn up by the Party.\nAs far as I know as a government employee, no conversations or other content are recorded on the internet, but we need to monitor the internet toprevent bad things from harming the Party and people.\nTom, you can't blame us that your opinion or that of another citizen is considered a lie.\nIf we believe that what you have said is a lie or is harmful to the Party, we mark that opinion as a lie.\nThose are the rules.");
                    Thread.Sleep(2000);
                    Six();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("I preferred to spend time with my friends as long as I could.\nUntil one of them says something that the Party dislikes and ... disappears.\nThere are also advantages to not being online.\nI met a lot of people and had time to learn a little bit of chemistry and physics.\nIf you know what I mean.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: I can see your chemistry and physics lessons have paid off.\nBut don't worry, the next classes will focus on different subjects.\nI am also very glad that you are socially active, Tom.\nIt is very important to have friends.\nWho do you think created the Party?\nA group of friends who were very devoted to their views, who wanted to change our country for the better.\nAnd they succeeded.");
                    Thread.Sleep(2000);
                    Six();
                    break;

                default:
                    NoneAnswer();
                    Five();
                    break;

            }
        }

        public static void Six()
        {
            Console.Clear();

            string choice;

            Text("L74x9: Alright Tom, at first you wanted to know what happened to your friends and I wrote that we'll talk about it later.\nThis is the time, Tom.\nIt is time to talk about your friends.\nSo all your friends are dead. Each one of them.\nI will tell you what happened.\nThe first 2 bombs of your robot went off too fast and killed two of your friends Steve and Brie.\nYou could also say that you killed them because you did the bomb wrong.\nBut that's for interpretation.\nThird bomb didn't go off and your friend William, trying to fix it, was shot by a brave and accurate policeman.\nInstead of running away, he tried to fix the bomb.\nHe really believed in what he was doing.\nBut what he believed was wrong.\nIt happens.\nThe last bomb was detonated accidentally by an already inaccurate policeman who wanted to shoot your friend Annie.\nThe policeman's mistake, however, is understandable, because what he was doing was stressful but also very heroic.\nYou are lucky Tom.\nAs you already know, only your bomb went off properly.\nA strange coincidence isn't it?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) Are you suggesting that I killed my friends?\n2) Everyone knew the consequences.\n3) It didn't go a way I wanted to go. I have failed them.\n52376: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("Are you suggesting that I killed my friends?\nWhat would be my goal in this?\nIt was a mistake.\nA simple mistake.\nMaybe I didn't learn chemistry and physics that well.\nBut I would never kill my friends, if someone were to die, it would be me.\nI would have sacrificed myself, and that's what I've been doing before blowing up that bomb.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: Tom, take it easy.\nI'm not suggesting anything.\nI'm just ... speculating.\nAfter all, I have to find out what happened and what led you to make these bombs.\nNobody's judging you for anything ... yet.");
                    Thread.Sleep(2000);
                    Seven();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("Everyone knew the consequences.\nEveryone knew that something could go wrong, that they might not come home, that they would probably go to labor camps or be executed immediatelyif they were caught.\nWe were all aware of the consequences, but we were also aware of what this attack could bring.\nNone of them died forcing the bomb to blow up.\nThey died but died by their free choice.\nThey all sacrificed themselves for us.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: Very nicely written, Tom.\nNow think about all the people you killed in Statsland Capitol.\nThese people had no choice but to die.\nThey did not know that they would not come home that day, that they would not see their loved ones anymore, that they would never see their\nmother again.\nThey had no idea.\nThey couldn't know it.\nThey couldn't have known a 20-year-old would kill them and his colleagues.\nThey had no choice but to survive.");
                    Thread.Sleep(2000);
                    Seven();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("It didn't go a way I wanted to go.\nI have failed them.\nI couldn't make those bombs.\nWhy only mine worked properly?\nMaybe I did it on purpose?\nI don't remember anymore.\nAfter the attack, I can't think of anything.\nMy brain is about to explode, and if not, I'll probably finish it myself.\nI killed innocent people and my friends.\nNobody can help me.\nBut we'll see what happens next.\nDon't you, Agent?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: I'm glad, Tom, that you are aware (almost) of what you have done and feel remorseful.\nThe party will surely take this into account when judging you.\nBut to answer your question yes.\nThere are literally a few more questions ahead of us.\nYou can still change your fate, Tom.\nBut it's up to you.");
                    Thread.Sleep(2000);
                    Seven();
                    break;

                default:
                    NoneAnswer();
                    Six();
                    break;

            }
        }

        public static void Seven()
        {
            Console.Clear();

            string choice;

            Text("L74x9: Tom, you know for sure that your coup sparked a general national riot.\nBut I don't know if you know the numbers killed in these protests.\nThis is obviously non-public data that did not see a day of day, so please ... don't share this data with anyone else.\nI can trust you? So far, about 7,000 Protestants and, unfortunately, about 550 brave and brave policemen have died.\nBut numbers can change very quickly, and we are also not able to count every body that quickly.\nStaying on the topic, I wonder if you have ever taken part in protests or similar gatherings?\nAnswer honestly, Tom.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) What does it matter whether I was taking it or not?\n2) I was taking because I wanted to change power and all the shit that's going on in the country.\n3) I prefer not to think about it.\n52376: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("What does it matter whether I was taking it or not?\nDo you want to know if I ever had any ... I don't know a killing tendency or what?\nYou want to blame all these people's deaths only on me.\nAny life that is lost is my fault only?\nFuck you.\nI won't say whether I took it or not.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: Tom, take it easy.\nNobody is forcing you to do anything.\nI'm not blaming the deaths of all those Protestants and policemen on you.\nI killed some Protestants with pleasure.\nSo you are not to blame for everything.\nBut you are definitely the cause of these deaths.");
                    Thread.Sleep(2000);
                    Eight();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("I was taking because I wanted to change power and all the shit that's going on in the country.\nI was hoping, like everyone else, that we could make a difference.\nWe were patient.\nThe results were poor.\nThat's why I did what I did now.\nEnd of waiting.\nAnd I did it.\nI gave them new hope.\nI gave them a chance.\nTo all those who hope for a better tomorrow.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: The only thing you've changed Tom so far is the daily kill count.\nFrom around 16 people a day to around 4,560 yesterday.\nThe average will definitely go up.\nBut I doesn't just blame you, I killed a few Protestants myself, and I have to admit it was a relief.\nI got happier right away.");
                    Thread.Sleep(2000);
                    Eight();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("I prefer not to think about it.\nI prefer not to remember my life before the attack.\nThinking and remembering only bring you pain and sorrow.\nI can't think straight after what I've done.\nI have such a confusion in my mind.\nNobody deserves such a punishment.\nAnd we haven't even finished talking and the real punishment is still ahead of me.\nNothing will be an equal punishment to what I have in mind.\nNo suffering is comparable.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: I like that attitude.\nI am glad that you are aware of your inevitable punishment, that you are already preparing mentally in a way.\nBut you have my word that we will try to make you suffer.\nYou know what? For me, the pain and sorrow went away when I killed some Protestants.\nIt really helped.\nSuch a kind of cleansing.\nBut of course you can't kill anyone ... you can't anymore.\nYou have already done your 'cleansing'.");
                    Thread.Sleep(2000);
                    Eight();
                    break;

                default:
                    NoneAnswer();
                    Seven();
                    break;

            }
        }

        public static void Eight()
        {
            Console.Clear();

            string choice;

            Text("L74x9: All right Tom.\nNext question.\nWhat is your relationship with your family?\nYou stay close and are close, or maybe you are in an argument and don't go to your mum for lunch on Sundays.\nThe second question is the same as the previous one but I mean your girlfriend.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) I have a good relationship with my family and girlfriend.\n2) I don't know, Agent, why do you need this information?.\n52367: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("I have a good relationship with my family and girlfriend.\nI love my parents like everyone else, and I don't want them to get hurt.\nThis is obvious.\nI would not like to see them suffer.\nSame with my girlfriend.\nI love her very much.\nI would have jumped into the fire after her.\nHe is the whole world to me.\nMy heart will break if something happens to my girlfriend or to my parents.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: I am very happy, Tom.\nYou need to cultivate love for parents and loved ones.\nI myself have a wife and a newborn child.\nYou have to explain to your loved ones what is good and what is bad.\nEven to just friends or even strangers.\nYou have to be sure that they are on the right side, because if they are not ... you have to, so to speak, 'convert' them.\nI myself am trying to 'convert' you.\nI want you to realize what you did and punished like a decent citizen.\nWith honor and pride.\nIf I fail, someone will replace me.\nBut that's good because if I fail, it means I'm not destined for this job.\nI will do anything for the Party.\nI will sacrafice myself for Party.");
                    Thread.Sleep(2000);
                    Nine();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("I don't know, Agent, why do you need this information?.\nWhat are they useful for? Do you want to compare yourself?\nI love my parents and my girlfriend.\nThey have nothing to do with what happened.\nThey didn't even know it.\nThey still probably don't know unless you told them who did it.\nThey are innocent.");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("L74x9: Any information, even what seems useless, might come in handy someday, Tom.\nBesides, it is not me who really sets these questions.\nThe party wants specific information and I will provide it to them.\nYou know, my wife and my child don't know what I'm doing either, so they're innocent too.\nBut I am ready to protect the Party at any cost, even if that cost is the health of my loved ones.");
                    Thread.Sleep(2000);
                    Nine();
                    break;

                default:
                    NoneAnswer();
                    Eight();
                    break;

            }
        }

        public static void Nine()
        {
            Console.Clear();

            string choice;

            Text("52376: Now it's my turn.\nYou kept asking me.\nAs a citizen of the Liberated Republic of Statesland, I deserve answers, I deserves at least one question and one answer.\nYou're a government employee, so you won't lie, right?");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Text("1) Why did you join Homeland Security?\n2) Why do you love the Party so much? What did Party give you?\n3) Do you believe in freedom?\n52367: ");
            
            

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("L74x9: You know Tom it's rude to act this way.\nBut why not.\nWe are already at the end of our conversation.\nPerhaps you will learn something about me or about the Party.\nAlways, as an employee of the government, I am ready to tell the truth and respond to ordinary citizens like you.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: Well ... I joined Homeland Security because I wanted to help the Party and the people.\nI wanted to uphold the law and justice.\nI wanted to 'change' something.\nSince I was a child, I was brought up in a family where love for the government is nurtured.\nI was always told that you have to love and support the government.\nI didn't quite like it.\nUntil the Party finally appeared.\nWith new ideas, with new people.\nTheir world view was so convincing and only true to me that I wanted to be part of this system.\nI wanted to act, not wait for it all to break down.\nI wanted to be there from the beginning.\nTogether with the Party.\nTogether with the people.\nThe party is my life.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("52376: I see it's too late to do anything with you and maybe change your mind.\nIt's a pity the Party has managed to manipulate people like you, it's still probably doing it.\nThe party has an impact on lives, but not in the way you imagine.\nThe party of life ruins and takes away.\n\nThank you for your reply. Even if it wasn't true.");
                    Thread.Sleep(2000);
                    LastQue();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("L74x9: You know Tom it's rude to act this way.\nBut why not.\nWe are already at the end of our conversation.\nPerhaps you will learn something about me or about the Party.\nAlways, as an employee of the government, I am ready to tell the truth and respond to ordinary citizens like you.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: I don't love the Party, the Party is just life.\nWithout the Party, there would be nothing.\nThere would be no freedom, there would be no happiness, there would be no ... us.\nThe party gave me and all of us everything.\nShe sacrificed herself and her comforts and good for us.\nShe didn't have to.\nShe could keep it to herself, but no ... she decided to sacrifice herself for us.\nI would do anything for the Party.\nNo matter what.\nWithout the Party, there is nothing, there is no you, no others, no ... me.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("52376: I see it's too late to do anything with you and maybe change your mind.\nIt's a pity the Party has managed to manipulate people like you, it's still probably doing it.\nThe party has an impact on lives, but not in the way you imagine.\nThe party of life ruins and takes away.\n\nThank you for your reply. Even if it wasn't true.");
                    Thread.Sleep(2000);
                    LastQue();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("L74x9: You know Tom it's rude to act this way.\nBut why not.\nWe are already at the end of our conversation.\nPerhaps you will learn something about me or about the Party.\nAlways, as an employee of the government, I am ready to tell the truth and respond to ordinary citizens like you.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Thread.Sleep(1000);
                    Text("L74x9: Tom, freedom is a broad concept.\nEveryone can interpret freedom differently.\nBut for me, freedom is the Party.\nThe party gave us freedom.\nWithout the Party, there would be no freedom, and there would only be chaos and lawlessness.\nBut the Party is not only freedom, the Party ... The Party is life.\nWithout the Party, this life does not exist.\nI would not like to live without the Party.");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Text("52376: I see it's too late to do anything with you and maybe change your mind.\nIt's a pity the Party has managed to manipulate people like you, it's still probably doing it.\nThe party has an impact on lives, but not in the way you imagine.\nThe party of life ruins and takes away.\n\nThank you for your reply. Even if it wasn't true.");
                    Thread.Sleep(2000);
                    LastQue();
                    break;

                default:
                    NoneAnswer();
                    Nine();
                    break;

            }
        }

        public static void LastQue()
        {
            Console.Clear();

            string choice;

            Text("L74x9: Okay, I ... now.\nUnfortunately, our conversation is over, Tom. " +
                "However, I hope I have helped a little bit in choosing your decision, a decision that will\ndetermine your entire future life and the lives of others. " +
                "About the lives of your relatives as well as the live of strangers." +
                "The decision, which\nmay decide the fate of thousands of people, can decide about the future fate of our wonderful country as well as the fate of other countries.\n" +
                "\nWhat are you going to do now, Tom?\n1) Maybe what I did was not fair or ... completely right, but the price of freedom is high.\n2) You're right, Agent. I was deluded.\n3) Many innocent people died because of me, but many of them was also really bad.\n52376: ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(" ");
                    Text("Maybe what I did was not fair or ... completely right, but the price of freedom is high.\nSome must sacrifice themselves so that all the rest gain. Freedom is my priority for which I will fight until the end of my perhaps\ndifficult life.\nThere are many people like me who will fight for freedom.\nPeople like me will never give up.\nAs long as people have hope, they will resist and fight for freedom, for choice and for ... peace.\nMaybe not everyone will see or appreciate it now, maybe some people will consider me an ordinary terrorist like you, but I did it so that no one else would have to do it, so that the next generations would have an easier life and have freedom.\nPeople don't want to survive, people want to live.");
                    Thread.Sleep(2000);
                    Ending1();
                    break;

                case "2":
                    Console.WriteLine(" ");
                    Text("You're right, Agent. I was deluded.\nI thought he was playing a hero who would save everyone and restore freedom to the world.\nBut life is not a fairy tale.\nLife is difficult and you have to live it and give thanks if you have enough to eat for breakfast.\nMy efforts are for nothing and my actions bring only death and sorrow.\nSo many innocent people died because of me.\nSo many children lost their mothers and fathers.\nTheir lives were changed in a split second when I made my decision and set off this bomb.\nPeople will probably consider me an ordinary terrorist like anyone else, which is true.\nI have so many lives on my conscience that I don't even know if I could sleep peacefully, let alone survive for another hour.\nI deserve an appropriate punishment for my actions.");
                    Thread.Sleep(2000);
                    Ending2();
                    break;

                case "3":
                    Console.WriteLine(" ");
                    Text("What I did could only seem fair to one of the parties, and looking at it now, it would only seem fair to one of the parties.\nMany innocent people died because of me, but many also the bad ones.\nI guess I could have approached it from a different angle.\nI might not have blown up the Statesland Capitol.\nI could have tried to resolve it peacefully, but on the other hand, such actions do not often work.\nI'm confused.\nIt is very possible that I have put into this act, such a huge act just not thinking enough, but you cannot plan forever, you have to act.\nI have to rethink what I did this time.\nIf you meet my family please tell them I'm okay and I'll be fine.\nI need a break, Agent.");
                    Thread.Sleep(2000);
                    Ending3();
                    break;

                default:
                    NoneAnswer();
                    Second();
                    break;

            }
            //Checked
        }

        public static void NoneAnswer()
        {
            Console.Clear();
            Console.WriteLine("L74x9: Tom did you ignore my question? I'll give you another chance. Focus this time, because your answer have huge impact on others and you.");
            Thread.Sleep(1000);
            //Checked
        }

        public static void Ending1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Text("Right after talking to Agent, Tom deletes the file named - cho1ce.exe.\n" +
                "Tom is shocked at the information he got from the Agent.\n" +
                "He decides to hide.\n" +
                "Tom doesn't speak to his family or friends so as not to endanger them.\n" +
                "But after two days he goes to join the riots in the streets and together with a few other protesters he organizes a group to motivate and give\nhope to others, but also to take further, perhaps more drastic actions using Tom's and others skills.\n" +
                "After two weeks, the riots have spread to all significant cities and the authorities have problems with controlling them.\n" +
                "Tom and his group blew up major Party offices and buildings.\n" +
                "Some Party people have surrendered and left or have been captured by Protestants and are being held in old schools and offices.\n" +
                "The revolution looks very promising.\n" +
                "The agent, on the other hand, was fired from his job, and his wife and her child fled.\n" +
                "The agent's location is unknown and he is wanted by Protestants.\n" +
                "The Statesland Liberated Party begins to lose power very quickly.\n" +
                "The rest of the countries found out about the riots, though the Statesland Liberated Party tried to hide it.\n" +
                "So far, about 15 countries plan to send their troops and police there to overthrow the Statesland Liberated Party and restore peace.\n" +
                "People join the riots and start seeing a new beginning, a new day.\t\t\n\n\t\t\t\t\t20,304 Protestants, 12,563 policemen and 2,450 party members died in the riots two weeks\n\t\t\t\t\tafter the conversation with Tom." +
                "\n\n\n\n\t\t\t\t\t\t\tGlory to reborn Liberated Statesland!");
            Thread.Sleep(3000);
            Credits();
            //Checked
        }

        public static void Ending2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Text("Tom, after voluntarily surrendering to Homeland Security, was sentenced to life in prison, in a prison of unknown location because it is a\ngovernment secret.\n" +
                "Tom has not spoken to anyone in two years, his family and loved ones are convicted of assisting in an assassination attempt and plotting against the party, and are serving 10 years in prison.\n" +
                "The riots and protests after Tom's arrest ended after two weeks and were completely suppressed, all the people who participated in them were\nquestioned and most of them ended up in jail and some disappeared without a trace.\n" +
                "Nobody from outside the country could help because the Statesland Liberated Party covered up the matter and closed the border shortly after the\nbombs exploded.\n" +
                "After the attack, the party reduced Chemistry and Physics in schools to the elementary level and removed all internet sources and books on\nthe subject.\n" +
                "People went back to their day-to-day affairs, and the Statesland Liberated Party continues to rule with a fair hand in the country to this day\nand is slowly but surely spreading its fair and free policy to other countries, from the smallest to the largest.\t\t\n\n\t\t\t\t\t7,304 Protestants and 563 policemen were killed in the riots." +
                "\n\n\n\n\t\t\t\t\t\tGlory to Liberated Republic of Statesland!");
            Thread.Sleep(3000);
            Credits();
            //Checked
        }

        public static void Ending3()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Text("After talking to the Agent, Tom immediately destroys the computer, keeping only the hard drive.\n" +
                "Immediately afterwards, Tom asks his friend a favor to transport him to South America in a fishing boat.\n" +
                "Tom manages to happily settle in a small village in the middle of the jungle, where he lives without electricity until today.\n" +
                "While Tom was fleeing the country, his parents and relatives were detained on suspicion of aiding in the assassination and conspiracy against\nthe Party, and were sentenced to 10 years in prison.\n" +
                "The riots and protests were crushed by the police, all Protestants were punished.\n" +
                "The agent who spoke to Tom was dismissed from his job and sentenced to 15 years in prison for aiding a terrorist and conspiring against the Party\n" +
                "People went back to their day-to-day affairs, and the Statesland Liberated Party continues to rule with a fair hand in the country to this day\nand is slowly but surely spreading its fair and free policy to other countries, from the smallest to the largest.\n\n\t\t\t\t\t17,304 Protestants and 2,563 policemen were killed in the riots." +
                "\n\n\n\n\t\t\t\t\t\tGlory to Liberated Republic of Statesland!");
            Thread.Sleep(3000);
            Credits();
            //Checked
        }

        public static void Ending4()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Text("After giving away the place of his hiding place, Tom is arrested in 30 minutes and brought to trial, which sentenced him to immediate execution.\n" +
                "6 hours later Tom dies in the electric chair, the whole event is broadcast on national television.\n" +
                "Tom's family and his relatives are sentenced to 10 years' imprisonment for aiding in the coup and conspiracy against the Party.\n" +
                "The riots and protests after Tom's arrest ended after two weeks, all the people who participated in them were questioned and most of them\nended up in jail, and some disappeared without a trace.\n" +
                "Nobody from outside the country could help because the Statesland Liberated Party covered up the matter and closed the border shortly after\nthe bombs exploded.\n" +
                "After the attack, the Party reduced Chemistry and Physics in schools to the elementary level and removed all internet sources and books on\nthe subject.\n" +
                "The agent is promoted to Chief Privacy Officer for the quick capture of the terrorist and later introduced an order to have cameras on all\nTV sets.\n" +
                "People went back to their day-to-day affairs, and the Statesland Liberated Party continues to rule with a fair hand in the country to this day\nand is slowly but surely spreading its fair and free policy to other countries, from the smallest to the largest.\t\t\n\n\t\t\t\t\t5,304 Protestants and 763 policemen were killed in the riots." +
                "\n\n\n\n\t\t\t\t\t\tGlory to Liberated Republic of Statesland!");
            Thread.Sleep(3000);
            Credits();
            //Checked
        }

        public static void Credits()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Text("\n\n\t\t\t\t\t\t\t   Code and writing by Michał Adamski");
            Thread.Sleep(2000);
            Text("\n\nTom, press 'Enter' to exit.");
            Console.ReadKey();
            //Checked

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RootManager : MonoBehaviour
{

    TextMeshProUGUI text;
    int i = 0;
    public static RootManager rootInstance;
    [SerializeField]
    AudioSource music;
    //16 картинок
    Image screen;
    [SerializeField]
    public Sprite img1;
    [SerializeField]
    public Sprite img2;
    [SerializeField]
    public Sprite img3;
    [SerializeField]
    public Sprite img4;
    [SerializeField]
    public Sprite img5;
    [SerializeField]
    public Sprite img6;
    [SerializeField]
    public Sprite img7;
    [SerializeField]
    public Sprite img8;
    [SerializeField]
    public Sprite img9;
    [SerializeField]
    public Sprite img10;
    [SerializeField]
    public Sprite img11;
    [SerializeField]
    public Sprite img12;
    [SerializeField]
    public Sprite img13;
    [SerializeField]
    public Sprite img14;
    [SerializeField]
    public Sprite img15;
    [SerializeField]
    public Sprite img16;

    private int currentRoot;
    public int CurrentRoot
    {
        get { return currentRoot; }

        set
        {
            currentRoot = value;
            //code
            PlayerPrefs.SetInt("CurrentRoot", currentRoot);
        }
    }

    private bool choose;

    public bool Choose
    {
        get { return choose; }
        set
        {
            choose = value;
            if (choose)
            {
                //vklyuchit knopki vibora
                //ChooseOne.oneInst.clickable = true;
                //ChooseTwo.twoInst.clickable = true;
                //viklyuchit vozmojnost skipa/pereklyucheniya soobsheniya
            }
            else
            {
                //viklyuchit knopki vibora
                //ChooseOne.oneInst.clickable = false;
                //ChooseTwo.twoInst.clickable = false;
                //vklyuchit vozmojnost skipa/pereklyucheniya soobsheniya
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rootInstance = this;
        screen = this.GetComponent<Image>();
        PlayerPrefs.SetInt("Root1", 0);
        PlayerPrefs.SetInt("Root2", 1);
        PlayerPrefs.SetInt("Root3", 2);
        PlayerPrefs.SetInt("Root4", 3);
        PlayerPrefs.SetInt("Root5", 4);
        PlayerPrefs.SetInt("Root6", 5);
        PlayerPrefs.SetInt("Root7", 6);

        //PlayerPrefs.DeleteKey("CurrentRoot");
        if (!PlayerPrefs.HasKey("CurrentRoot"))
        {
            PlayerPrefs.SetInt("CurrentRoot", PlayerPrefs.GetInt("Root1"));
            CurrentRoot = PlayerPrefs.GetInt("CurrentRoot");
        }

        //Начало игры
        PlayerPrefs.SetString("Root0String0",
            "For many years, the world was shaken by wars. " +
            "Mankind was systematically destroying itself in endless conflicts. " +
            "History has taught us that there is always a strong claimant to the territory of the weak. " +
            "And then, in a brave new time, man, unable to keep track of his own freedom, gave it to the immaculate "
            );
        PlayerPrefs.SetString("Root0String1",
            "machines-the new masters of human destinies. No one remembers for what fairy tales about security, " +
            "stability and happiness people sold themselves into slavery to ever-developing and logically invulnerable " +
            "neural networks, but the fact remains that machines saw an unquestioning benefit in people " +
            "and the high-energy biofuels they produced. "
            );
        PlayerPrefs.SetString("Root0String2",
            "Only God knows how many years on earth there is sodomy " +
            "and literal milking of everything possible from unconscious bodies, though... " +
            "God has probably already left this place"
            );
        PlayerPrefs.SetString("Root0String3",
            "It was during one of the breaks in the endless cycles of the harvest that you awoke. " +
            "Awoke from the eternal unconscious horror that passes through your head like a high-speed train locomotive, " +
            "sweeping away all attempts of the mind to stabilize the situation in its path. "            
            );
        PlayerPrefs.SetString("Root0String4",
            "I wonder how the creators of this infernal system, who provided the complex implementation of \"source code\" " +
            "(predsednik memories stored in the brain by stimulating neural nodes that give people the intelligence " +
            "and reflexes of an average adult individual, so necessary for the proper functioning of the reproduction system), "
            );
        PlayerPrefs.SetString("Root0String5",
            "but missed the side effect of forcing madness from awareness of the inevitability to exist " +
            "as dairy cattle the next 60 years."
            );
        PlayerPrefs.SetString("Root0String6",
            "For the first few minutes after you switched off, you got used to doing what you knew how to do in your brain, " +
            "but you tried for the first time - walking, talking to yourself, and focusing your eyes on one point. " +
            "It was surprisingly simple. " 
            );
        PlayerPrefs.SetString("Root0String7",
            "Now you are left alone, in a room with a hellish apparatus " +
            "that the torturers of Chinese and European monarchs will envy, and the knowledge that there, " 
            );
        PlayerPrefs.SetString("Root0String8",
            "somewhere behind the door, is someone who is responsible for all your endless torment. " +
            "You can only choose to stay and lose sanity, or run away and get your revenge..."
            );
        PlayerPrefs.SetString("Root0String9",
            "So you have choosen escape..."
            );
        PlayerPrefs.SetString("Root0String10",
            "Once in the doorway, you couldn't help but thinking that you have a beautiful wife, " +
            "children and hot eggs waiting for you at home. "
            );
        PlayerPrefs.SetString("Root0String11",
            "The more colorful your brain was drawing an excuse " +
            "for your escape adventure, making a vague picture of the imposed memories, " +
            "the more painful it was to realize the severity of reality, " +
            "where you might be the only person who got out of the cycle."
            );
        PlayerPrefs.SetString("Root0String12",
            "So it's time to choose: in front of you, under the ceiling, there is a hole in the ventilation shaft. " +
            "Despite your obvious recklessness, which allowed you to escape from the comfort of the torture chamber, " +
            "you felt afraid to move further along the corridor. "
            );
        PlayerPrefs.SetString("Root0String13",
            "Despite the fact that it will be objectively easier to move on your feet than crawling through a tunnel, " +
            "you once again think about missing that opportunity..."
            );
        string[] root0 = 
        { 
            PlayerPrefs.GetString("Root0String0"), 
            PlayerPrefs.GetString("Root0String1"), 
            PlayerPrefs.GetString("Root0String2"),
            PlayerPrefs.GetString("Root0String3"),
            PlayerPrefs.GetString("Root0String4"),
            PlayerPrefs.GetString("Root0String5")
        };
        //Начало первого выбора

        //Начало Root1
        PlayerPrefs.SetString("Root1String0",
            "Running out into the corridor, you found yourself in a long system of catacombs, " +
            "the edges of which are arranged with automatic precision in the layout of the cells. " +
            "You go to one of them and see a girl who is in the middle of the harvest. "
            );
        PlayerPrefs.SetString("Root1String1",
            "The Robo-hands had just finished introducing a minimum diet of nutrients to the captive, " +
            "when they instantly began to stimulate her erogenous zones to obtain the necessary norm " +
            "of biomaterial in the shortest possible time. "
            );
        PlayerPrefs.SetString("Root1String2",
            "The machine does not need to think about foreplay, " +
            "when the victim is tightly bound and can not resist - the robot sticks to the girl's clitoris with a manipulator " +
            "with a villous funnel and brings her to orgasm in 10 seconds... "
            );
        PlayerPrefs.SetString("Root1String3",
            "And then to the second, to the third. " +
            "You think about how lucky men are to be physically unable to bring themselves to multiple ejaculations. " +
            "All you have to do is step away from the camera and move on."
            );
        PlayerPrefs.SetString("Root1String4",
            "Down the corridor you encountered a huge problem-it turned out that the complex is patrolled by creepy robots - " +
            "a masterful creation of a sick strategy overmind AI has. "
            );
        PlayerPrefs.SetString("Root1String5",
            "Their bodies are full of sharp edges, and their hands operate with tools not for collecting but for " +
            "destroying biomass. "
            );
        PlayerPrefs.SetString("Root1String6",
            "On their monitors, you can see something resembling human features, but so disfigured that " +
            "the spontaneous movement of the eyes and mouth only causes stupor and the desire to kill yourself before it gets " +
            "to you. "
            );
        PlayerPrefs.SetString("Root1String7",
            "You are lucky that you noticed them at a decent distance and you are given a unique " +
            "opportunity to choose an escape route... Distract the guards by throwing a stone into the adjacent corridor or " +
            "hide behind a supporting column?"
            );
        //Начало выбора первого рута

        //Начало Root2
        PlayerPrefs.SetString("Root2String0",
            "Automatons are by their nature straightforward, so that to completely distract their attention, " +
            "it is enough to set a task with an illusory goal of completion. "
            );
        PlayerPrefs.SetString("Root2String1",
            "So it was quite enough to throw a rock into the void, so that they spent the time immediately " +
            "before the scheduled restart searching for the source of the noise. Perfect NPCs, " +
            "it's worth praising your resourcefulness."
            );
        PlayerPrefs.SetString("Root2String2",
            "Your sick imagination is playing out in the repetitive corridors of the complex. " +
            "There doesn't seem to be a single social or economic problem of humanity that you haven't solved in your head. "            
            );
        PlayerPrefs.SetString("Root2String3",
            "Not a single joke that you didn't run on the open mike and didn't put in your special, " +
            "exclusive to brain parasites only. In that cell on the left, you no doubt saw Natalie Portman in her Prime, " +
            "with whom Matthew McConaughey is having sex. "
            );
        PlayerPrefs.SetString("Root2String4",
            "And in the right-hand corner, " +
            "furry lovers had an Orgy in themed costumes... This is getting weird."
            );
        PlayerPrefs.SetString("Root2String5",
            "Surprisingly, your adventures were crowned with success - the sign \"rooms of the main management of the camp grounds\" " +
            "does allude to this. "
            );
        PlayerPrefs.SetString("Root2String6",
            "The last obstacle between you and the coveted lever " +
            "for opening all cells/the self-destruct button of the complex/the push plate of doom " +
            "(underline the right one) is the door itself. "
            );
        PlayerPrefs.SetString("Root2String7",
            "Strange, but this room is obviously entered after " +
            "primitive password input with primitive fingers on the panel to the right of the door. " +
            "Is all this Sodom run by a man? Just open the door and find out!"
            );
        //Начало выбора второго рута

        //Начало Root3
        PlayerPrefs.SetString("Root3String0",
            "Control center for the entire complex. Cameras, video Surveillance, doors, " +
            "pipes for distilling biomaterial, everything-at your feet! "            
            );
        PlayerPrefs.SetString("Root3String1",
            "Here begins the Endgame of your tragicomedy, " +
            "it remains only to find a conditional lever and release everyone! "
            );
        PlayerPrefs.SetString("Root3String2",
            "How ironic, a few hours ago you were a nobody, " +
            "a pawn on the losing side of someone else's chess game, " +
            "and now you have reached the edge and become the third player who can turn the entire table! "
            );
        PlayerPrefs.SetString("Root3String3",
            "Your wombs are bubbling with excitement and thoughts of a bright future. " +
            "However, the hum of monitors and the hiss of hard drives was interrupted by a lasting female moan."
            );
        PlayerPrefs.SetString("Root3String4",
            "\"Ahh, a living person! I should have asked how you got here, " +
            "but my womb is too swollen at the thought of what you can do with your dignity in person!\""
            );
        PlayerPrefs.SetString("Root3String5",
            "Person... no, a demon! Before you stands a succubus of incredible beauty in the most shameless guise made of latex. " +
            "Her appearance clearly indicates that she is extremely \"excited\"."
            );
        PlayerPrefs.SetString("Root3String6",
            "\"These machines are nothing compared to You, humans." +
            "Even though they control you, your physique doesn't leave a dry spot on me! "
            );
        PlayerPrefs.SetString("Root3String7",
            "For hundreds of years of domination, they could not even think of anything better than poking " +
            "a guest with an iron cold pipe in the shape of a dick!\""
            );
        PlayerPrefs.SetString("Root3String8",
            "You lose the thread of the story in this conversation on the verge of ecstasy - " +
            "only her hints of sex and the sight of her make your penis emit a preeculant"
            );
        PlayerPrefs.SetString("Root3String9",
            "\"We, succubs, are amazed by your creative approach to self - " +
            "satisfaction on the verge of mental breakdown! "
            );
        PlayerPrefs.SetString("Root3String10",
            "When we came here, we didn't even have to seduce men for sperm! " +
            "Your robots have meekly agreed to deduct our species part of the production of just a couple of lines of code!\""
            );
        PlayerPrefs.SetString("Root3String11",
            "You are already on the edge, " +
            "only stoic endurance and thoughts of the good for all mankind stop you from " +
            "Baring your penis and starting to masturbate"
            );
        PlayerPrefs.SetString("Root3String12",
            "\"I have been following all the men in this complex for " +
            "several decades and only dream of how they would all fall on me with their own..."
            );
        PlayerPrefs.SetString("Root3String13",
            "Aaaahh...with their hard Dicks! I beg you to condescend to me with your huge, powerful penis!\""
            );
        PlayerPrefs.SetString("Root3String14",
            "You're done, the bets are made, " +
            "one hand is tearing your pants, the second is masturbating the lever, " +
            "you must urgently make a choice!"
            );
        //Начало выбора третьего рута - финала (коллективный трах/ соло трах)

        //Текст коллективного траха
        PlayerPrefs.SetString("Final1String0",
            "\"Do you want to feel the anger of a hundred men ? !So I'll fix it for you, bitch!\""
            );
        PlayerPrefs.SetString("Final1String1",
            "You pull the already Smoking lever and all the cameras open almost synchronously, " +
            "you can see how all the people crawl out of prison with a degree of bewilderment. " +
            "You can only direct their forces in the right direction."
            );
        PlayerPrefs.SetString("Final1String2",
            "\"All men, report to unit 1 door 120, complex control center." +
            "The revolution demands punishment for the SEO of this hell!\""
           );
        PlayerPrefs.SetString("Final1String3",
            "The reaction was not long in coming, " +
            "and soon more than a hundred men crowded into the hall, " +
            "looking hungrily at the succubus - the former camp Manager."
            );
        PlayerPrefs.SetString("Final1String4",
            "\"Yes, sweet! All so sweet! Be harder on me!\""
            );
        PlayerPrefs.SetString("Final1String5",
            "The succubus took every hot shot from every ex-con. " +
            "Each of them is trained to a level that even the most skilled succubus can't handle. "
            );
        PlayerPrefs.SetString("Final1String6",
            "One dick after another, charge after charge, slap after slap, " +
            "the consciousness of the ruler of man's virtues went from objective reality to uncontrolled ecstasy. " +
            "The mad Rodeo bordered on literal rape, apparently, gave the starved succubus a storm of satisfaction. "
            );
        PlayerPrefs.SetString("Final1String7",
            "She accelerated with each new person and took it deeper, periodically losing consciousness. " +
            "On about the 150th person, it was a shapeless mass of twitching muscles and Contracting holes, " +
            "and the sperm on it swirled without drying out. "
            );
        PlayerPrefs.SetString("Final1String8",
            "It's hard to count how many times she came, " +
            "but if there was a Valhalla for succubi, it would look something like this."
            );
        PlayerPrefs.SetString("Final1String9",
            "Soon after the incident, " +
            "there was a wave of riots in most of these camps and you were listed as the first liberator of mankind. "
            );
        PlayerPrefs.SetString("Final1String10",
            "It turned out that the AI has long been mired in a lot of banal paradoxes, " +
            "and only because of this succubi were able to establish similar systems to your camp. " +
            "Thanks to you people have hope for a bright future"
            );
        PlayerPrefs.SetString("Final1String11",
            "And now I can tell you..."
            );
        PlayerPrefs.SetString("Final1String12",
            "... That you have chosen escape... and you succeeded!"
            );
        //Конец первого финала

        //Текст соло траха суккуба
        PlayerPrefs.SetString("Final2String0",
            "You can't take your eyes off her, and your hand comes off the lever. " +
            "She is immediately there and knocks you to the ground. "
            );
        PlayerPrefs.SetString("Final2String1",
            "You are still in your clothes, " +
            "but she sat on you so that you feel your crotch powerful contractions slightly deeper than her labia. " +
            "The succubus's gaze rolls in anticipation and she rips your ragged pants off your legs " +
            "and tears up her latex mini shorts without looking at you. "
            );
        PlayerPrefs.SetString("Final2String2",
            "She inserts your penis without warning " +
            "and the heavy atmosphere of expectation is torn by a mutual groan. "
            );
        PlayerPrefs.SetString("Final2String3",
            "If you didn't go through the daily sexual training, " +
            "you would have already finished on the way to her vagina, " +
            "so there was a pleasant heat between her legs. "
            );
        PlayerPrefs.SetString("Final2String4",
            "Her juices were so much that you did not feel anything but a solid ecstasy from sliding over the heated tunnel. " +
            "She moved away from the full ecstasy to pay respect to your restraint, " +
            "because she expected the first charge immediately. "
            );
        PlayerPrefs.SetString("Final2String5",
            "She bared her Breasts to increase the aesthetic effect and forcefully pressed your hands into them, " +
            "after which she began her truly diabolical Rodeo with loud moans. "
            );
        PlayerPrefs.SetString("Final2String6",
            "But you were unyielding, straining in a stance that prevented early ejaculation, " +
            "you allowed yourself to experience insane forward movements along the length of your " +
            "dick with the exciting squelch of her lush buttocks in a puddle of her juices and your preeculant. "
            );
        PlayerPrefs.SetString("Final2String7",
            "She did not take pity and during the orgasm took you for the entire length, " +
            "the convulsions of her womb and an inhumanly sexual moan brought you to orgasm. "
            );
        PlayerPrefs.SetString("Final2String8",
            "Incredibly powerful, causing her tongue to literally fall out the entire length of " +
            "her mouth and empty a little saliva on her chest. Finally, " +
            "for the succubus in her vagina had something hotter than her own walls, "
            );
        PlayerPrefs.SetString("Final2String9",
            "she immediately finished the second time in ecstasy, " +
            "deducting the score again in favor of you and squeezing the penis to a pleasant spasm."
            );
        PlayerPrefs.SetString("Final2String10",
            "The problem was that the succubus in sex can be satisfied to the end only by exhausting to " +
            "the point of unconsciousness the sum of two factors: sexual and physical exhaustion. "
            );
        PlayerPrefs.SetString("Final2String11",
            "Unfortunately for you, both of you are physically exhausted, " +
            "but it is impossible to sexually exhaust a succubus, "
            );
        PlayerPrefs.SetString("Final2String12",
            "so you continued your race of orgasms until you completely passed out, " +
            "and as a result of all the orgasms and continued use of your erect dick while you were unconscious, " +
            "your heart stopped."
            );
        PlayerPrefs.SetString("Final2String13",
            "You may have missed humanity's chance of rehabilitation last night, " +
            "but you certainly didn't miss the best sex of your life!"
            );
        PlayerPrefs.SetString("Final2String14",
            "And now I can tell you..."
            );
        PlayerPrefs.SetString("Final2String15",
            "... That you have chosen escape... and you failed!"
            );
        //Конец второго финала

        //Начало Root4
        PlayerPrefs.SetString("Root4String0",
            "You got into a vent - put up with the back pain and leg swelling for the next few hours, " +
            "but you made your choice. "
            );
        PlayerPrefs.SetString("Root4String1",
            "Your existence can be compared to a mole with Alzheimer's syndrome, " +
            "who dug out a complex of tunnels and completely forgot where the exit is. "
            );
        PlayerPrefs.SetString("Root4String2",
            "Assuming theoretically the vastness of the ventilation network, " +
            "you decide to stick to the left wall in the hope of not getting lost. " +
            "Thus, shamed by the inner ego, but not broken, you continue your movement."
            );
        PlayerPrefs.SetString("Root4String3",
            "After some time of cosplaying a Vietcong fighter in an ancient and forgotten war, " +
            "you almost lose your mind when something grabs your leg. "
            );
        PlayerPrefs.SetString("Root4String4",
            "The story of the greatest escape in modern history has come to an end - " +
            "now you will either go back to your cell, " +
            "or you will be hacked by the infernal taskmaster machine for the amusement of your colleagues. "
            );
        PlayerPrefs.SetString("Root4String5",
            "But everything turned out to be much more interesting - " +
            "when you turned around, you met the girl's eyes. " +
            "Her face seemed as familiar to you as it was strange. "
            );
        PlayerPrefs.SetString("Root4String6",
            "But now, unable to say anything to each other, you mentally agree to cooperate in your escape. " +
            "The adventure gets an accomplice, " +
            "and you - a unique view from behind, " +
            "in a gentlemanly way, giving the lady to crawl forward."
            );
        PlayerPrefs.SetString("Root4String7",
            "After crawling through the tunnels for several hours, " +
            "you already roughly understood the structure of your burrow and realized that the designer of the " +
            "building was guided by basic logic, connecting all the branches in the vent with the Central core, " +
            "which leads to the largest doors that you could only imagine. "
            );
        PlayerPrefs.SetString("Root4String8",
            "Now you and your companion were separated from the theoretical exit from the complex by only one ventilation grate... " +
            "and one evil warden at the entrance. "
            );
        PlayerPrefs.SetString("Root4String9",
            "You were already thinking of a plan for further action, " +
            "when you noticed that your friend twists the loops from the grid and clearly hints to " +
            "Unscrew a few loops from the robot itself. "
            );
        PlayerPrefs.SetString("Root4String10",
            "You appreciate the initiative, " +
            "but it can be punished. Will you hold down and set an example for the lady, " +
            "or will you both run into the overseer and fight your way to freedom?"
            );
        //Начало выбора четвертого рута

        //Начало Root5
        PlayerPrefs.SetString("Root5String0",
            "The idea of waiting was questionable in the conditions of the need to quickly escape from the complex, " +
            "but your unprofessionalism played into the wrong gate - " +
            "the robot received an order over the speakerphone to inspect the open cells. " +
            "Probably it was about Your ones."
            );
        PlayerPrefs.SetString("Root5String1",
            "Going down to an empty hall feeling the whole body taste of an easy victory, " +
            "for which you literally did not have to do anything, your brain decides to perform a gambit. " +
            "Whether because of the stress of being in a narrow room for too long, " +
            "or because of General fatigue, he gives the best joke from his repertoire:"
            );
        PlayerPrefs.SetString("Root5String2",
            "\"You know what's the strangest thing about a man?\""
            );
        PlayerPrefs.SetString("Root5String3",
            "She just gave me a quizzical look as I looked forward to an incredible punchline"
            );
        PlayerPrefs.SetString("Root5String4",
            "\"A man is a creature that once got out of a woman and then most of his life tries to get into her!\""
            );
        PlayerPrefs.SetString("Root5String5",
            "It was awful, but it amused her. Perhaps bad Comedy exists only for the sake of such situations."
            );
        PlayerPrefs.SetString("Root5String6",
            "You were right across from a huge gate-like doors. " +
            "Theoretically, all you have to do is wave through the partially opened part of them, " +
            "but again something stops you. "
            );
        PlayerPrefs.SetString("Root5String7",
            "The thin, drawling voice of reason tells you that you should find a way around, " +
            "that the main entrance will be more of a problem for the two escapees, " +
            "even if they are escapees from a complex where escape is not expected. "
            );
        PlayerPrefs.SetString("Root5String8",
            "You can't say the same about your companion - her desire to run straight forward exceeds her doubts. " +
            "What will you do?"
            );
        //Начало выбора пятого рута

        //Начало Root6
        PlayerPrefs.SetString("Root6String0",
            "You rushed through the main entrance, " +
            "because who does not risk, " +
            "he does not escape from the yoke of evil AI. "
            );
        PlayerPrefs.SetString("Root6String1",
            "There is no limit to your happiness until the entire complex is alerted"
            );
        PlayerPrefs.SetString("Root6String2",
            "You can only run, run without looking back - this is the only way you can count on salvation. " +
            "Escape turns into an unspoken race and you even began to win it. "
            );
        PlayerPrefs.SetString("Root6String3",
            "Suddenly, a manipulator tentacle bursts out of the wall and grabs your partner by the hair. " +
            "A nasty thought crossed your mind:\"there's no way to save her.\" " +
            "But you've actually spent most of your adult life with her.You have a hard choice to make..."
            );
        //Начало выбора шестого рута, выбор концовок (трах/не трах)

        //Текст не траха
        PlayerPrefs.SetString("Final3String0",
            "You won't make a mistake this time. " +
            "You have considered all possible options and faced an insurmountable problem. "
            );
        PlayerPrefs.SetString("Final3String1",
            "An objective assessment of the situation on the run tells you that there is no other way out, " +
            "you have both worked at this moment literally all your adult lives. "
            );
        PlayerPrefs.SetString("Final3String2",
            "You understood that there is no way back and there will not be a second chance - " +
            "you have a huge responsibility to save, perhaps, " +
            "the last hope of humanity and tacitly understood that there is no simple solution, " +
            "no small evil. "
            );
        PlayerPrefs.SetString("Final3String3",
            "Either one of them escapes and says that there is always a chance, " +
            "or both of them will lie down in a senseless attempt to save both of them. "
            );
        PlayerPrefs.SetString("Final3String4",
            "You did not stand up for the price and made a decision - she may not like it, " +
            "or even you may not, but it is effective, rational."
            );
        PlayerPrefs.SetString("Final3String5",
            "You run without looking back, hoping for her forgiveness, but you will never be able to forgive yourself."
            );
        PlayerPrefs.SetString("Final3String6",
            "After several years of wandering through the forests, " +
            "you find traces of a recently broken camp - you have already met similar, " +
            "but older places and have long guessed that you are not unique in your fate " +
            "and could logically assume that free humanity exists! "
            );
        PlayerPrefs.SetString("Final3String7",
            "People no longer build monumental cities, because they are afraid of raids from Superintelligent AI, " +
            "but its functionality does not allow it to effectively deal with nomadic communities. "
            );
        PlayerPrefs.SetString("Final3String8",
            "For them, it has become more of an evil celestial being that can not be defeated, " +
            "but only to offer eternal pilgrimageon the land it does not have power on. "
            );
        PlayerPrefs.SetString("Final3String9",
            "It's amazing how adaptive the human species are! " +
            "All you have to do is to follow the tracks and soon you'll come across one of the societies. " +
            "I just hope they'll accept you."
            );
        PlayerPrefs.SetString("Final3String10",
            "You have come a long way, but your hardships and successes are just beginning. Now I can tell you..."
            );
        PlayerPrefs.SetString("Final3String11",
            "... That you have chosen escape... and you succeeded, but what cost?"
            );
        //Конец третьего финала

        //Начало соло траха в лесу
        PlayerPrefs.SetString("Final4String0",
            "You stop abruptly and run after her - she has taken up too much space in your short life to just leave it here. " +
            "You imagined how they would have crushed it to pieces, while you are breaking the servos of the manipulator. "
            );
        PlayerPrefs.SetString("Final4String1",
            "You imagined how she would cry and howl in primal terror, " +
            "when you are sliding through pools of engine oil on the floor and finally almost drowning in desperate thoughts, " +
            "how you would lose the only person you loved in your life, " +
            "hugging her as if she were a handful of the smallest sand in your palm. "
            );
        PlayerPrefs.SetString("Final4String2",
            "Sand, without which it would not be possible to build the Foundation of hope for humanity. " +
            "By not letting her away from you, you're getting both of you out of this hell."
            );
        PlayerPrefs.SetString("Final4String3",
            "You did manage to escape. Together. " +
            "You spend the last hour lying on the grass in a pristine forest about " +
            "10 kilometers from the place where you awoke from horror a day ago, " +
            "rising like a Phoenix from the ashes of humanity. "
            );
        PlayerPrefs.SetString("Final4String4",
            "You don't know what you will do next, how the compass needle of your destiny will turn, " +
            "but you are happy with it, here and now. "
            );
        PlayerPrefs.SetString("Final4String5",
            "She just needs to give a hint of what she is missing right now and your thoughts start to sing in unison, " +
            "You lead and quickly find yourself on top - " +
            "years of sex education would put you in a row with the hardiest representatives of humanity at the " +
            "beginning of the 21st century. you look into each other's eyes and every second you are grateful for your meeting."
            );
        PlayerPrefs.SetString("Final4String6",
            " You gently enter her young body, hoping for an approving reaction from your partner - " +
            "a loud moan of pleasure fills the forest silence. Her thin hands dig into the wet grass, " +
            "and her legs wrap around your back in an attempt to tame the convulsions of pleasure. "
            );
        PlayerPrefs.SetString("Final4String7",
            "Your rhythmic movements cause her Breasts to sway, " +
            "revealing a stunning view that delivers no less aesthetic pleasure than your penis gets in her hot bosom. " +
            "You are so hungry for each other that you can't slow down for half an hour, "
            );
        PlayerPrefs.SetString("Final4String8",
            "bringing each other tons of pleasure, but the act comes to its endgame: " +
            "She feels the throb of your penis and asks you to finish inside. " +
            "You meekly agree and in emotional ecstasy you merge in a passionate kiss and end up together, as it should be."
            );
        PlayerPrefs.SetString("Final4String9",
            "You don't want to move away from each other by a millimeter, " +
            "so you fall asleep on top of each other. After sleeping until the morning, " +
            "you do not hurry to get up, playing with each other until lunch, " +
            "lucky yesterday to find a clearing with berries and porcini!"
            );
        PlayerPrefs.SetString("Final4String10",
            "This is not the end of your story, " +
            "you will still have many hardships and successes on the way, " +
            "but here I can tell you..."
            );
        PlayerPrefs.SetString("Final4String11",
            "... That you have chosen escape... and you succeeded "
            );
        //Конец соло траха в лесу

        //Первая смерть HIde
        PlayerPrefs.SetString("WrongChoice1String0",
            "You're hiding behind a pillar, " +
            "so you won't get in the line of sight of the Warders, right? " +
            "Well, unfortunately, this isn't that video game, son, and you aren't wining it. " +
            "While one robot pinned you to this very column, the second slowly dismembered you into 8 pieces. " +
            "It's a pity you died of pain shock on the third incision. "
            );
        //Конец первой смерти

        //Вторая смерть Bruteforce 
        PlayerPrefs.SetString("WrongChoice2String0",
            "Unfortunately for you, " +
            "the first attempt to guess a password was unsuccessful and triggered the alarm. " +
            "Pretty quickly, your pathetic attempts at bruteforce came to be evaluated " +
            "by local law enforcement in empty corridors officials. " +
            "I'm sorry, but you are screwed up - now your fate will be decided by three soulless circular saws on metal feet."
            );
        //Конец второй смерти

        //Третья смерть Fight Him
        PlayerPrefs.SetString("WrongChoice3String0",
            "You weren't Sam Whitwick, " +
            "and she wasn't Sarah Connor, " +
            "so you quickly found your partner without an arm, and your head separated from your body. " +
            "You could have watched for a few more seconds as " +
            "the robot tore her fragile body in half while she screamed in agony with a note of envy for you, " +
            "because you died painlessly enough."
            );
        //Конец третьей смерти

        //Четвертая смерть Find Alternatives
        PlayerPrefs.SetString("WrongChoice4String0",
            "It was really stupid - time is playing against you, " +
            "there are God knows how many hostile robots in the complex, " +
            "and one of them went to check your cameras and found your absence in them. " +
            "Alarm throughout the complex did not take long to wait - " +
            "before you had time to go through a couple of storerooms with " +
            "spare parts for punishers and tentacles for milking machines, " +
            "all the doors were closed and you just had to wait for the punishment. " +
            "Your partner hates you."
            );
        //Конец четвертой смерти

        //ГЕЙмовер скрин
        PlayerPrefs.SetString("DeathString0",
            "You're dead. " +
            "You chose it yourself, or it was chosen for you - the result is inevitable. " +
            "After all, people are fragile and impermanent, and machines are N. O. T."
            );
        PlayerPrefs.SetString("DeathString1",
            "... That you have chosen escape... and you failed"
            );
        //Конец геймовер скрина

        PlayerPrefs.SetString("TextRoot1", "Go forward");
            PlayerPrefs.SetString("TextRoot3", "Trick them");
                PlayerPrefs.SetString("TextRoot5", "Check It");
                    PlayerPrefs.SetString("TextRoot7", "Crush Her");
                        //PlayerPrefs.SetString("TextRootFinal1", "Crush Her");
                    PlayerPrefs.SetString("TextRoot8", "Fuck Her");
                        //PlayerPrefs.SetString("TextRootFinal2", "Fuck Her");
                PlayerPrefs.SetString("TextRoot6", "Bruteforce It");
            PlayerPrefs.SetString("TextRoot4", "Hide");

        PlayerPrefs.SetString("TextRoot2", "Go vents");
            PlayerPrefs.SetString("TextRoot9", "Wait Out");
                PlayerPrefs.SetString("TextRoot11", "Rush Through");
                    PlayerPrefs.SetString("TextRoot13", "Save Her");
                        //PlayerPrefs.SetString("TextRootFinal3", "Концовка в лесу");
                    PlayerPrefs.SetString("TextRoot14", "Leave Her");
                        //PlayerPrefs.SetString("TextRootFinal4", "Соло концовка");
                PlayerPrefs.SetString("TextRoot12", "Find Alternatives");
            PlayerPrefs.SetString("TextRoot10", "Fight Him");

        text = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
        text.text = "Click on screen to start.";

        Debug.Log(PlayerPrefs.GetInt("CurrentRoot"));
        Debug.Log(PlayerPrefs.GetFloat("MusicVolume"));

        Choose = false;
        PlayerPrefs.SetInt("Choose", 0);
        PlayerPrefs.SetInt("CurrentRoot", 0);
        CurrentRoot = PlayerPrefs.GetInt("CurrentRoot");
    }

    private void OnMouseDown()
    {
        if (TextWriter.ended && !Choose)
        {
            switch (CurrentRoot)
            {
                case 0:
                    switch (i)
                    {
                        case 0:
                            //Отобразить картинку BE1B
                            screen.sprite = img9;
                            Choose = false;
                            music.Play();
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String0"));
                            i++;
                            break;
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String1"));
                            i++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String2"));
                            i++;
                            break;
                        case 3:
                            //Отобразить картинку AB49
                            screen.sprite = img6;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String4"));
                            i++;
                            break;
                        case 5:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String8"));
                            i++;
                            break;
                        case 9:
                            //Отобразить картинку ECA0
                            screen.sprite = img13;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String10"));
                            i++;
                            break;
                        case 11:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String11"));
                            i++;
                            break;
                        case 12:
                            //Отобразить картинку A76A
                            screen.sprite = img5;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String12"));
                            i++;
                            break;
                        case 13:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root0String13"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                case 1:
                    switch (i)
                    {                   
                        case 1:
                            //Отобразить картинку C345
                            screen.sprite = img10;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String1"));
                            i ++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String2"));
                            i ++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String3"));
                            i ++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String4"));
                            i ++;
                            break;
                        case 5:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String5"));
                            i ++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String6"));
                            i ++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root1String7"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                case 2:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String1"));
                            i ++;
                            break;
                        case 2:
                            //Отобразить картинку A76A
                            screen.sprite = img5;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String2"));
                            i++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String4"));
                            i++;
                            break;
                        case 5:
                            //Отобразить картинку 0E3A
                            screen.sprite = img1;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root2String7"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                case 3:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String1"));
                            i ++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String2"));
                            i ++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String3"));
                            i ++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String4"));
                            i ++;
                            break;
                        case 5:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String5"));
                            i ++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String6"));
                            i ++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String7"));
                            i ++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String8"));
                            i++;
                            break;
                        case 9:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String10"));
                            i++;
                            break;
                        case 11:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String11"));
                            i++;
                            break;
                        case 12:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String12"));
                            i++;
                            break;
                        case 13:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String13"));
                            i++;
                            break;
                        case 14:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root3String14"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                case 4:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String1"));
                            i++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String2"));
                            i++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String4"));
                            i++;
                            break;
                        case 5:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String8"));
                            i++;
                            break;
                        case 9:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root4String10"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                case 5:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String1"));
                            i++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String2"));
                            i++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String4"));
                            i++;
                            break;
                        case 5:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root5String8"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                case 6:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root6String1"));
                            i ++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root6String2"));
                            i ++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Root6String3"));
                            i = 1;
                            Choose = true;
                            PlayerPrefs.SetInt("Choose", 1);
                            break;
                    }
                    break;
                //Deaths
                case 10:
                    switch (i)
                    {
                        case 1:
                            //Отобразить картинку BE1B
                            screen.sprite = img9;
                            TextWriter.StartWriting(PlayerPrefs.GetString("DeathString0"));
                            i ++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("DeathString1"));
                            i = 0; 
                            CurrentRoot = 0;
                            PlayerPrefs.SetInt("CurrentRoot", 0);
                            break;
                    }
                    break;
                //Finals
                case 11:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String1"));
                            i++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String2"));
                            i++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String4"));
                            i++;
                            break;
                        case 5:
                            music.Stop();
                            //Отобразить картинку с проном1
                            screen.sprite = img14;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String8"));
                            i++;
                            break;
                        case 9:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String10"));
                            i++;
                            break;
                        case 11:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String11"));
                            i++;
                            break;
                        case 12:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final1String12"));
                            i = 0;
                            CurrentRoot = 0;
                            PlayerPrefs.SetInt("CurrentRoot", 0);
                            break;
                    }
                    break;
                case 12:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String1"));
                            i++;
                            break;
                        case 2:
                            music.Stop();
                            //Отобразить картинку прон2
                            screen.sprite = img15;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String2"));
                            i++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String4"));
                            i++;
                            break;
                        case 5:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String8"));
                            i++;
                            break;
                        case 9:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String10"));
                            i++;
                            break;
                        case 11:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String11"));
                            i++;
                            break;
                        case 12:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String12"));
                            i++;
                            break;
                        case 13:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String13"));
                            i++;
                            break;
                        case 14:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String14"));
                            i++;
                            break;
                        case 15:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final2String15"));
                            i = 0;
                            CurrentRoot = 0;
                            PlayerPrefs.SetInt("CurrentRoot", 0);
                            break;
                    }
                    break;
                case 13:
                    switch (i)
                    {
                        case 1:
                            music.Stop();
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String1"));
                            i++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String2"));
                            i++;
                            break;
                        case 3:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String4"));
                            i++;
                            break;
                        case 5:
                            //Отобразить картинку CDC8
                            screen.sprite = img11;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String5"));
                            i++;
                            break;
                        case 6:
                            //Отобразить картинку A0D0
                            screen.sprite = img4;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String8"));
                            i++;
                            break;
                        case 9:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String10"));
                            i++;
                            break;
                        case 11:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final3String11"));
                            i = 0;
                            CurrentRoot = 0;
                            PlayerPrefs.SetInt("CurrentRoot", 0);
                            break;
                    }
                    break;
                case 14:
                    switch (i)
                    {
                        case 1:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String1"));
                            i++;
                            break;
                        case 2:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String2"));
                            i++;
                            break;
                        case 3:
                            //Отобразить картинку A0D0
                            screen.sprite = img4;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String3"));
                            i++;
                            break;
                        case 4:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String4"));
                            i++;
                            break;
                        case 5:
                            music.Stop();
                            //Оотбразить прон3 
                            screen.sprite = img16;
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String5"));
                            i++;
                            break;
                        case 6:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String6"));
                            i++;
                            break;
                        case 7:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String7"));
                            i++;
                            break;
                        case 8:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String8"));
                            i++;
                            break;
                        case 9:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String9"));
                            i++;
                            break;
                        case 10:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String10"));
                            i++;
                            break;
                        case 11:
                            TextWriter.StartWriting(PlayerPrefs.GetString("Final4String11"));
                            i = 0;
                            CurrentRoot = 0;
                            PlayerPrefs.SetInt("CurrentRoot", 0);
                            break;
                    }
                    break;
            }
        } 
        else
        {
            TextWriter.StopWriting();
        }
    }
}

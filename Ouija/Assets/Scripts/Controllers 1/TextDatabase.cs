using UnityEngine;
using System.Collections.Generic;

public class TextDatabase : MonoBehaviour
{

    public Dictionary<string, string> WeaponDescriptions = new Dictionary<string, string> {

        { "Knife", "A tarnished silver kitchen knife with an ornate hilt." },
        { "Lorenz Rifle", "An old rifle of Austrian design. The barrel is rusted, but it might still fire." },
        { "Hydrochloric Acid", "A bottle containing a clear corrosive chemical." },
        { "Rope", "A dirty and frayed piece of rope. It looks like a single tug could rip it apart." },
        { "Axe Head", "A piece of an old axe now completely rusted over. The rotted remains of the handle are still attached." },
        { "Bookshelf", "A large shelf of cypress wood lies on the floor. Its books are in surprisingly good condition, but you don’t see anything of interest." },
        { "Lead Pipe", "A piece of plumbing from an era before people cared about water safety." },
        { "Chandelier", "A massive chandelier at least six feet wide. Its broken in many places. It must have fell from the ceiling long ago." },
        { "Bathtub", "An old iron tub. It's still full of a murky brown water." },
        { "Pillow", "A white pillow with a floral design. It's been expertly stitched together." }

    };

    public Dictionary<string, string> MiscItemDescriptions = new Dictionary<string, string>{
        {"Table","A wooden table. It's still in decent condition, actually."},
        {"Chair","A wood chair. What are those markings on the legs? Claw marks?"},
        {"Dresser","When you open the drawer, a few moths fly out. The dresser is still full of ancient clothes, though all of them you find are full of holes."},
        {"Bucket","A rotted wooden bucket. It looks like it might fall apart if you tried to pick it up."},
        {"Teapot","A hand-painted teapot. It is decorated with paintings of finches."},
        {"Spoon","An old-ass spoon."},
        {"Fork","An old-ass fork"},
        {"Cheese","A moldy piece of cheese Louie intended to eat before he died. Thinking about how his ghost might one day return for the cheese fills you with determination."},
        {"Statue","A statue of a creature with an Alligator-like head, a humanoid torso, and insect legs. It is carved from a mysterious red stone that you’ve never seen before."}
    };
    
    
    

    public Dictionary<string, string> CharacterDescriptions = new Dictionary<string, string> {
        {"Louis Prejean","He is a fat man with curly hair. He sports a mustache and a southern beard. He has scaly patches of skin on his face. He wears a stylish white sunhat."},
        { "Adam Abrams", "He is a burly man with short dark hair and a mustache, but no beard. He has a bald spot. He wears a trench coat and slacks, both dark brown." },
        {"Dr. Bernard Simoneaux","He has a “sharp” nose, and ears that protrude noticeably from the side of his head. A hat rests atop his his curly blonde hair. His eyes are soft and green. He wears a black overcoat and blue undershirt complete complete with a tie."},
        {"Claudia BelleFleur","She is a tall woman long dark hair and pale skin. She has alluring eyes and a smile on her face that you just can’t quite place. She wears a green dress to match her eyes."},
        {"Gina Prejean","She is a short woman with long dark hair. She has blue eyes and full lips on her rounded face. She wears a ruffled floor-length violet dress."},
        {"Augustine Prejean","He is a lanky young man with short dark hair. He eyes are blue like his mother’s. He would have a handsome face, but for the patches of scales. He wears a brown suit with a bowtie."}
    };

    public Dictionary<string, string> RoomDescriptions = new Dictionary<string, string> {

        { "Foye", "A beautiful entrance hall." }

    };

    public Dictionary<string, string> Clues = new Dictionary<string, string> {

        {"Adam Clue 1", "Evidence #1 \n\rCase: 342 \n\rEntrant: Adam Abrams \n\rDescription: REDACTED.\n\r"},

        {"Adam Clue 2", "Evidence #2 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r" +
            "Description:  fingerprints found at the crime scene.\n\r" +
            "UPDATE: It appears these are actually palm prints which would not be in the database.\n\r"},

        { "Bernard Clue 1", "Evidence #3 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r" +
            "Description: A list of chemicals including Hydrochloric Acid.\n\r"},

        { "Bernard Clue 2", "Evidence #4 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r" +
            "Description: an arm found dismembered cleanly, more cleanly than I’ve ever seen in a murder case before.\n\r"},

        {"Gina Clue 1", "Evidence #5 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r Description: A strand of long dark hair found on the body.\n\r"
         },

        {"Gina Clue 2", "Evidence #6 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r Description: The body was burned in an attempted cremation along with a large amount of cash.\n\r"
        },

        {"Augustine Clue 1", "Evidence #7 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r Description: A strand of short dark hair found on the body.\n\r"
        },

        {"Augustine Clue 2", "Evidence #8 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r Description: The body shows heavy bruising after time of death.\n\r"
        },

        {"Claudia Clue 1", "Evidence #9 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r Description: A strange marking on  the body.\n\r"
        },

        {"Claudia Clue 2", "Evidence #10 \n\rCase: 342 \n\rEntrant: Adam Abrams\n\r Description: A queer black substance."+
            " It is neither solid nor liquid. If only I could file it away and never need look at it again.\n\r"
        },


    };


    public Dictionary<string, string> Notes = new Dictionary<string, string> {


        {"Louis Note 1", "            My name is Louis Prejean. I’m writing this note because I don’t have much time left. There’s already been one attempt on my life. My secret is out. My enemies know. But I don’t know who my enemies are, so I jump at every shadow.\n\r" +
        "            This whole time Gina’s been telling me to get out, to think about the consequences. I did think about the consequences, but I never regretted my actions. I’ve been quite successful and my family has been quite successful. I second-guessed myself, sure, but I kept myself convinced that I was going down the right path.\n\r"+
        "            But if I only regret it now that I’m going to die, that’s not really regret, is it? The truth is I’m terrified of death. I’ve killed people before because I thought they might kill me at some point, and I can’t be at ease until either I kill my stalker or my stalker kills me.\n\r"+
        "\n\rLouis Prejean\n\rApril 12, 1861\n\r"},
        {"Louis Note 2","Dear Dr. Simoneaux,\n\r             When I came to the hospital, I was in a scrape. All of the doctors turned me away. Seeing as I had no money, they said my illness wasn’t vicious enough. All of them but you. I understand you lost your job for taking so much time off from the paying patients.\n\r              I won’t forget what you’ve done, Bernie. You’re going to be quite a rich man. I guarantee it.\n\r \n\r Louis Prejean,\n\r April 18, 1854\n\rEnter your input text here and click a text formatting function button below.Dear Dr. Simoneaux,\n\r             When I came to the hospital, I was in a scrape. All of the doctors turned me away. Seeing as I had no money, they said my illness wasn’t vicious enough. All of them but you. I understand you lost your job for taking so much time off from the paying patients.\n\r              I won’t forget what you’ve done, Bernie. You’re going to be quite a rich man. I guarantee it.\n\r \n\r Louis Prejean,\n\r April 18, 1854\n\rDear Dr. Simoneaux,\n\r             When I came to the hospital, I was in a scrape. All of the doctors turned me away. Seeing as I had no money, they said my illness wasn’t vicious enough. All of them but you. I understand you lost your job for taking so much time off from the paying patients.\n\r              I won’t forget what you’ve done, Bernie. You’re going to be quite a rich man. I guarantee it.\n\r \n\r Louis Prejean,\n\r April 18, 1854\n\r"},

        {"Adam Note 1","            I begin my investigation of Louis Prejean. It’s just a hunch really. There’s no evidence, nothing to tie him to any of it. Nonetheless, this mysterious string of deaths has benefitted one person. You guess which one.\n\r \n\r Adam Abrams\n\r March 3, 1861\n\rEnter your input text here and click a text formatting function button below.            I begin my investigation of Louis Prejean. It’s just a hunch really. There’s no evidence, nothing to tie him to any of it. Nonetheless, this mysterious string of deaths has benefitted one person. You guess which one.\n\r \n\r Adam Abrams\n\r March 3, 1861\n\r           I begin my investigation of Louis Prejean. It’s just a hunch really. There’s no evidence, nothing to tie him to any of it. Nonetheless, this mysterious string of deaths has benefitted one person. You guess which one.\n\r \n\r Adam Abrams\n\r March 3, 1861\n\r"},
        {"Adam Note 2","            There’s no evidence of any criminal activity going on in the Prejean’s plantation. Normally I would cross Prejean off of the suspect list, but I have noticed some strange things around here. I haven’t told anyone from the department about this. No one would believe me if I did.. Honestly, I don’t completely believe it myself.\n\r            But some of the slaves are mad. They utter nonsense and I’ve seen one eating her own hand. There are artifacts in the plantation, voodoo dolls, and some kind of crocodilian statue made of a stone I’ve never seen before. And of course there’s Louis Prejean himself. He says his scaly skin is because of an illness, but I’m not sure I believe that.\n\r\n\rAdam Abrams\n\rMarch 15, 1861\n\r"},
        {"Adam Note 3","            Last night I was witness to such an atrocity as I cannot describe with words. I had been outside the mansion, waiting for some slip up as I had done incrementally for weeks. At length it came tonight. I spotted Louis Prejean and his son, Augustine leaving the mansion at approximately 3:00 A.M.\n\r            I followed them into the woods, and now I wish that I hadn’t. In my days on the force, I’ve seen some things.  I’ve seen children, bruised and half-way dead when by the time I got there.  I’ve seen my fellow officers, people that I was good friends with, shot dead by thugs.\n\r            But If I were to fully record the Satanic rituals performed under the moonlit sky that night, my mind might collapse completely. I will say that Louis did things to his son that would have made me vomit if I weren’t already vomiting. And the creatures… no, I mustn’t write about the creatures. I mustn’t think about those writhing flesh-shadows again.\n\r            Louis is beyond the power of the law, but clearly I cannot leave this be. If such devilry cannot be touched by the law, then I want no more to do with the law. I will end this myself.\n\r\n\rAdam Abrams\n\rApril 4, 1861\n\r"},
        {"Adam Note 4","            I had a conversation with Dr. Simoneaux. He is a medical researcher with a lab in Louie’s mansion. Louie supposedly keeps him around to treat his illness. I’ve seen him around, but I never spoke much with him until today.\n\r            He had a queer yet familiar look in his eyes and he spoke about life and death. What is justice and what right do we have to play God and take lives?\n\r            It began to dawn on me where I’d seen that look before. I’d seen it in the eyes of murderers, and I’d seen it in my owns eyes as I’d looked into the mirror that morning. What makes me different from them? My job is simply to carry out the law. I mustn’t act as the judge jury and executioner. Louis has to have some weakness. Even if we cannot get him for his most vicious crimes, I will find something, and we will put him behind bars.\n\r\n\rAdam Abrams	\n\rApril 12, 1861\n\r"},

        {"Bernard Note 1","            I’ve never seen aught like this. The patient’s skin has taken on an appearance that I can only describe as “scaly”.\n\r            Two weeks ago, he was coughing up blood. His face was the face of a man clinging to life. I prescribed him medication after medication, and at length it seems I’ve got it right.\n\r            Well, Louis will live for now anyway, but I’m going to have to break it to him tonight. By my best reckoning, he has a few years left to him.\n\r\n\rBernard Simoneaux M.D.\n\rJanuary 26,1854\n\r"},
        {"Bernard Note 2","            It's been a pretty strange seven years. First I lost my job, then these mysterious illnesses break out. Illnesses only I can heal. I’ve made more money than I’ll find necessary just selling my books. My career is not only back on track, but I’m flourishing. I’m now the chair at the LSU school of medicine. \n\r            I’ve been pretty blessed… and yet I feel as if I am cursed. The heads of the hospital I worked at all died with huge welts upon their skin. After they fired me, fired me for helping someone in need, I even wished they were dead, but I felt so ashamed when they did die. \n\r            But it's not just that. Everywhere I go people become ill. A good many of them die. Other doctors can do nothing to save them, but when I do the simplest things they recover as if by some miracle.\n\r            I recall the letter I received from Louis Prejean. At the time, I thought he was full of it, or maybe he would get around to paying me back eventually. But no, he said I would be wealthy. I’m sure this is his doing now as I’ve looked into him recently, and he’s become a millionaire through equally dark and mysterious ways. Just as they have with me, everyone who has stood in Louis’s path has died.\n\r\n\rBernard Simoneaux\n\rDecember 28, 1853\n\r"},
        {"Bernard Note 3","            Louis Prejean was happy to give me my own medical research lab when I sought him on the matter. I expected he would set me up in close neighborhood, but I now have a facility right in his own home.\n\r            He is every bit as much of a monster as I had thought, and more. As a man of science, I want to say that I don’t believe there’s a such thing as the devil, but it's as if fantasy has now entered into reality. Did I go mad? No, I really can’t believe that I have.\n\r             As a doctor my job is to save lives, not to take them. But what if to save many lives I had to take one person’s life? I saved this demon’s life, and this is how he repays me. He is my responsibility now.\n\r\n\rBernard Simoneuax\n\rApril 11, 1853\n\r"},
        {"Bernard Note 4","            I was standing there before him. Louie just stared at me, wide-eyed and shivering as if he had known this was coming.\n\r            And what I saw was a fearful man, an ambitious and ruthless man, but still a man. A man who cared about his family, and cared about me.\n\r            I don’t know what mechanisms he used to commit his crimes, but I can say that I don’t believe there is a such thing as a devil in this world.\n\r            I’m leaving. I suppose I’ll retire to some unknown countryside. Louie’s agreed to stay out of my affairs. It would be my greatest pleasure to never see or hear from him again.\n\rBernard Simoneuax\n\rApril 12, 1853\n\r"},

        {"Gina Note 1","Dear Linda,\n\r            I worry about Louie’s escapades. I never liked the Bellefleur woman. Something about her was always off. But I never did think…\n\r            For a while I just knew he was hiding something from me, but “Louie isn’t that kind of man,” I told myself. But I’ve got to face reality. I just don’t know what to do.\n\r\n\rGina Prejean,\n\rNovember 3, 1853\n\r"},
        {"Gina Note 2","Dear Linda,\n\r            It's like I hardly know Louie. We’ve been married for more than twenty years, but after what I’ve found out…\n\r            It's not just the unfaithfulness. I wish that were all of it. My life seemed so bad at the time when I thought my husband was being unfaithful to me, but now I just wish I could go back to those times.\n\r            He has a Ouji board, a device from the devil, and there are darker things going on, deep evil things I couldn’t bare to write about. All this wealth and success? Is this what my husband traded his soul for?\n\r            I’ve thought about leaving, but what do I tell the children? And I have nowhere else to go anyway. The doctor said Louie’s illness was terminal, so that is what I’ve chosen to do. I just wait. Wait for him to die.\n\r\n\rGina Prejean,\n\rJanuary 10, 1860\n\r"},
        {"Gina Note 3","            I’ve made a terrible mistake. Gus broke out with a terrible fever. I thought he was going to die. That is the only reason I agreed to it.\n\r            ...No, I’m the one that begged Louie to save Gus. But what came back from the swamp isn’t Gus.\n\r            Louie isn’t going to die on his own. I know now that he used voodoo to keep himself alive. He isn’t going to die on his own. I can’t let him hurt my family any more. Gus, he’d be better off dead than this. And Anna, I have to protect Anna. I have to be strong and do this.\n\r\n\rGina Prejean\n\rApril 12, 1861\n\r"},
        {"Gina Note 4","            I couldn’t do it. I kept telling myself I would do it, but when the moment came I just froze up. He threatened me and he threatened the children. I can’t kill him or even attempt to.\n\r            There’s nothing I can do anymore. There’s nothing I can do, but try not to think about any of it. Go into my head. Pretend I don’t exist.\n\r\n\rGina Prejean\n\rApril 12, 1861\n\r"},

        {"Augustine Note 1","            I recall our dog, Sandy. Sandy used to always stare right at me, and I would wonder what what she was thinking. Until one day, I realized she was staring just behind me.\n\r            Sandy died six months ago. I got used to the the scratching sounds on the door living with a dog. But they haven’t stopped.\n\r            Anna has heard it too. I think our folks have no idea.\n\r\n\rAugustine Prejean,\n\rMay 1, 1856 \n\r"},
        {"Augustine Note 2","            Father knows. He has a board with letters and magnolia trees that he keeps in a box under the stairs. I’ve heard my folks talking. Mother says that the board is going to suck his soul in. \n\rBut whenever I try to bring any of it up, they both act like nothing is going on. I’m ill of being treated like a child. Has Father brought the devil into this house?\n\r\n\rAugustine Prejean,\n\rJuly 22, 1858\n\r"},
        {"Augustine Note 3","            I nearly died twice recently. Once when my skin broke out into scales, the same illness as my father. The second time was because of my father.\n\r            He used me. He used me to fuel his magic, just as he’s used the slaves before. I’ve seen them go insane, and now I fear I have. I’ve seen them, crawling across the walls of our house, all scales and death and insect parts. Only I can see them.\n\r            And they tell me things. They tell me to kill my father. They tell me kill me he is the source of my suffering, and his death shall release me.\n\r\n\rAugustine Prejean,\n\rApril 5, 1861\n\r"},
        {"Augustine Note 4","            I’ve failed. There was a wall of the creatures protecting him. And when I lunged at Father, they laughed and me. They wrapped their centipede bodies around me and melted with me through the floor.\n\r            It is all black down here, blackness forever, but not because there is no light.\n\r\n\rAugustine Prejean,\n\rApril 12, 1861\n\r"},

        {"Claudia Note 1","Dear Louie,\n\r            I won’t beat about the bush. I’ve heard of your illness and I can help. I can save your life. It comes at a price, but it won’t cost you a dime. We will talk when I arrive.\n\r\n\rClaudia Bellefleur\n\rApril 4, 1854\n\r"},
        {"Claudia Note 2","My Dear Louie,\n\r            It was a pleasure to be in your company, and I can assure you that you’ve made the right decision. \n\r            Now that we have become one, He Who Rests Beneath The Swamps will surely bless you. Great things. Great things are to come. Don’t think that I exaggerate. Your skin already bears his mark; It is proof that he favors you. Soon you will not merely comprehend the power of our Lord, but wield it.\n\r\n\rUntil the Swamp calls out to us again,\n\rClaudia Bellefleur\n\rApril 21, 1854 \n\r"},
        {"Claudia Note 3","            The vessel is nearly ready for the sacrifice. Soon the Nameless One will walk among the living once more. The Prawns are gathering and the vessel will soon be at peak ripeness. In just a few days we will bring this seven year ritual to a close.\n\r            Actually, I’m beginning to have second thoughts. Our Lord is one to be feared for sure. So far, he has been mostly benevolent towards his children. But after the ritual he will be free, and I’m afraid he may not need us anymore.  I’m not sure. But I have to go forward and sacrifice Louis. Everyone, including the anointed leader expects me to. I’m not sure which way is more dangerous. Perhaps I ought to think of a way to weasel out of this responsibility?\n\r            Now is hardly the time to ask questions, anyway. Maybe I’m just paranoid from playing cat and mouse so long. Always looking for humans’ ulterior motives. Our Lord doesn’t think like a human.\n\r\n\rClaudia Bellefleur\n\rApril 8, 1861\n\r"},
        {"Claudia Note 4","To our anointed leader,\n\r            We have succeeded. Well, things did not go as I planned, but it seems that the Lord of the Swamp had his own plans. When we came to sacrifice Louis, we found he was already dead.\n\r            But the timing was right. The sacrifice was completed.  I have given his body to the Swamp. Soon, the Nameless Darkness will have a name. He will bring new and bloodier kinds of death to mankind. We will subjugate this nation. Today it begins.\n\rClaudia Bellefleur\n\rApril 12, 1861\n\r"}
    };

    
    public List<string> GetMiscItemList(){
        return new List<string>(MiscItemDescriptions.Keys);
    }

    public List<string> GetWeaponList()
    {
        return new List<string>(WeaponDescriptions.Keys);
    }

    public List<string> GetCharacterList()
    {
        return new List<string>(CharacterDescriptions.Keys);
    }

    public List<string> GetRoomList()
    {
        return new List<string>(RoomDescriptions.Keys);
    }

    public List<string> GetClueList()
    {
        return new List<string>(Clues.Keys);
    }

    public List<string> GetNoteList()
    {
        return new List<string>(Notes.Keys);
    }

}

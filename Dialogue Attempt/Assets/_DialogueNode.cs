using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DialogueNode {

    public int nodeID = -1;
    public string sentence;
    public List<_DialogueOption> options;


    //empty constructor used for xml serialization - won't need if not programmatically creating dialogue
    public _DialogueNode()
    {
        options = new List<_DialogueOption>();
    }

    public _DialogueNode(string sentence)
    {
        this.sentence = sentence;
        options = new List<_DialogueOption>();
    }

}

/*used a tutorial for dialogue structure: 
 * LarsIsGaming 
 * https://www.youtube.com/watch?v=wnhvu99A1tg
 * https://www.youtube.com/watch?v=ILQND0Mb9TQ
 * Used classes (Dialogue, DialogueOption, and DialogueNode) as shown as well as the xml file structure, but created a 
 * scriptable object for controlling the dialogue rather 
 */

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class _Dialogue {

    public List<_DialogueNode> Nodes;

    public _Dialogue()
    {
        Nodes = new List<_DialogueNode>();
    }

    /// <summary>
    /// Loads a dialogue from an xml path (must deserialize it in order to cast it as a _Dialogue object)
    /// </summary>
    /// <param name="path">string path to the xml file (which should be in Assets)</param>
    /// <returns>returns the _Dialogue object with information read from the xml file</returns>
    public static _Dialogue LoadDialogue(string path)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(_Dialogue));
        StreamReader reader = new StreamReader(path);

        _Dialogue dia = (_Dialogue)xmlSerializer.Deserialize(reader);

        return dia;
    }


}


/*used a tutorial for dialogue structure: 
 * LarsIsGaming 
 * https://www.youtube.com/watch?v=wnhvu99A1tg
 * https://www.youtube.com/watch?v=ILQND0Mb9TQ
 * Used classes (Dialogue, DialogueOption, and DialogueNode) as shown as well as the xml file structure, but created a 
 * scriptable object for controlling the dialogue rather 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Sentence : ScriptableObject {
    [TextArea(2, 4)]
    public string sentence;
    [TextArea(2, 4)]
    public string optionOne = "";
    [TextArea(2, 4)]
    public string optionTwo = "";
    [TextArea(2, 4)]
    public string optionThree = "";

    

}

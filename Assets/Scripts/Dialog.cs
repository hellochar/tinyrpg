using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    private static GameObject dialogPrefab;

    public void showDialog(GameObject obj, string text, bool autoHide)
    {
        AudioSource source = obj.GetComponent<AudioSource>();
        if (source != null)
        {
            source.Play();
        }

        TextMesh textMesh = obj.GetComponentInChildren<TextMesh>();
        if (textMesh == null)
        {
            if (Dialog.dialogPrefab == null)
            {
                Dialog.dialogPrefab = Resources.Load("Prefabs/Dialogue") as GameObject;
            }
            GameObject dialogObject = Instantiate(dialogPrefab, obj.transform);
            textMesh = dialogObject.GetComponent<TextMesh>();
        }

        textMesh.text = text;
        textMesh.transform.localPosition = new Vector3(0, 0.5f, -1f);
        if (autoHide)
        {
            StartCoroutine(hideTextAfter(textMesh, 0.25f * text.Length));
        }
    }

    private IEnumerator hideTextAfter(TextMesh text, float time)
    {
        yield return new WaitForSeconds(time);
        text.text = "";
    }
}

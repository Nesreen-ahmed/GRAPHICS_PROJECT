using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public const int gridRows = 2;
    public const int gridCols = 6;
    public const float offsetX = 7.5f;
    public const float offsetY = 10f;
    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;
    public AudioSource s;
    public AudioSource q;
    public GameObject ballon;

    private void Start()
    {
        Vector3 startPos = originalCard.transform.position; //The position of the first card. All other cards are offset from here.

        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3,4,4,5,5 };
        numbers = ShuffleArray(numbers); //This is a function we will create in a minute!

        for (int i = 0; i < gridCols; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                MainCard card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MainCard;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
    }

    private int[] ShuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------

  private MainCard _firstRevealed;
    private MainCard _secondRevealed;

    private int _score = 0;
    [SerializeField] private TextMesh scoreLabel;

    public bool canReveal
    {
        get { return _secondRevealed == null; }
    }


    public void CardRevealed(MainCard card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }
        else
        {
            _secondRevealed = card;
            StartCoroutine(CheckMatch());
        }
    }
    
    private IEnumerator CheckMatch()
    {
        if (_firstRevealed.id == _secondRevealed.id)
        {
            _score++;
            scoreLabel.text = "Score: " + _score;
            if (_score == 6)
            {
                q.Play();
                ballon.SetActive(true); 
                yield return new WaitForSeconds(2f);
                _firstRevealed.gameObject.SetActive(false);
                _secondRevealed.gameObject.SetActive(false);
                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene("menu");
            }
            else
            {
                s.Play();
            }

            yield return new WaitForSeconds(2f);
            _firstRevealed.gameObject.SetActive(false);
            _secondRevealed.gameObject.SetActive(false);

        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            _firstRevealed.Unreveal();
            _secondRevealed.Unreveal();
        }

        _firstRevealed = null;
        _secondRevealed = null;

    }

   
}

using UnityEngine;
using UnityEngine.UI;
public class Turno : MonoBehaviour
{
	public GameObject aluria;
	public GameObject kane;
	public GameObject rayssa;
	public GameObject lilith;
	public GameObject tarir;
    public GameObject ellis;
    public Text label;
    public Text gameover;
	public Camera camera1;
	public Camera camera2;
	int turn;

    public GameObject Ellis
    {
        get
        {
            return ellis;
        }

        set
        {
            ellis = value;
        }
    }

    // Use this for initialization
    void Start ()
	{
		turn = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if  (Input.GetKeyDown (KeyCode.Home)){
			// Kane
		re: if  (turn == 0){
				if (kane.GetComponent<Dano> ().isDead ()) {
					turn = 1;
					goto re;
				}
				/*else if(tarir.GetComponent<Dano>().isDead()){
					label.text = "Player 1: Kane";
					label.color = new Color (255f,0f,0f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (true);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Kane> ().setAtive (false);
					turn = 5;
					camera1.enabled = true;
					camera2.enabled = false;
				}*/
				else {
					label.text = "Player 1: Kane";
					label.color = new Color (255f,0f,0f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (true);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Ellis> ().setAtive (false);
					turn = 1;
                    kane.GetComponent<Kane>().resetPassos();
                    camera1.enabled = true;
					camera2.enabled = false;
				}
			}
			//Aluria
			else if (turn == 1) {
				if (aluria.GetComponent<Dano> ().isDead ()) {
					turn = 2;
					goto re;
				} 
				/*else if (ellis.GetComponent<Dano> ().isDead ()) {
					label.text = "Player 2: Aluria";
					label.color = new Color (0f,0f,255f);
					aluria.GetComponent<Aluria> ().setAtive (true);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Kane> ().setAtive (false);
					turn = 0;
					camera1.enabled = false;
					camera2.enabled = true;
				}*/
				else {
					label.text = "Player 2: Aluria";
					label.color = new Color (0f,0f,255f);
					aluria.GetComponent<Aluria> ().setAtive (true);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Ellis> ().setAtive (false);
                    aluria.GetComponent<Aluria>().resetPassos();
					turn = 2;
					camera1.enabled = false;
					camera2.enabled = true;
				}
			}
			//Rayssa
			else if (turn == 2) {
				if (rayssa.GetComponent<Dano> ().isDead ()) {
					turn = 3;
					goto re;
				}
				/*else if(kane.GetComponent<Dano>().isDead()){
					label.text = "Player 1: Rayssa";
					label.color = new Color (255f,0f,0f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (true);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Kane> ().setAtive (false);
					turn = 1;
					camera1.enabled = true;
					camera2.enabled = false;
				}*/
				else{
					label.text = "Player 1: Rayssa";
					label.color = new Color (255f,0f,0f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (true);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Ellis> ().setAtive (false);
                    rayssa.GetComponent<Rayssa>().resetPassos();
					turn = 3;
					camera1.enabled = true;
					camera2.enabled = false;
				}
			}
			//Lilith
			else if (turn == 3) {
				if (lilith.GetComponent<Dano> ().isDead ()) {
					turn = 4;
					goto re;
				} 
				/*else if(aluria.GetComponent<Dano>().isDead()){
					label.text = "Player 2: Lilith";
					label.color = new Color (0f,0f,255f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (true);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Kane> ().setAtive (false);
					turn = 2;
					camera1.enabled = false;
					camera2.enabled = true;
				}*/
				else {
					label.text = "Player 2: Lilith";
					label.color = new Color (0f,0f,255f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (true);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Ellis> ().setAtive (false);
                    lilith.GetComponent<Lilith>().resetPassos();
					turn = 4;
					camera1.enabled = false;
					camera2.enabled = true;
				}
			}
			//Tarir
			else if (turn == 4) {
				if (tarir.GetComponent<Dano> ().isDead ()) {
					turn = 5;
					goto re;
				}	/*else if(rayssa.GetComponent<Dano>().isDead()){
					label.text = "Player 1: Tarir";
					label.color = new Color (255f,0f,0f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (true);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Kane> ().setAtive (false);
					turn = 3;
					camera1.enabled = true;
					camera2.enabled = false;
				} */
				else {
					label.text = "Player 1: Tarir";
					label.color = new Color (255f,0f,0f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (true);
					ellis.GetComponent<Ellis> ().setAtive (false);
                    tarir.GetComponent<Tarir>().resetPassos();
					turn = 5;
					camera1.enabled = true;
					camera2.enabled = false;
				}
			}
			//Ellis
			else if (turn == 5) {
				if (ellis.GetComponent<Dano> ().isDead ()) {
					turn = 0;
					goto re;
				} /*else if(lilith.GetComponent<Dano>().isDead()) {
					label.text = "Player 2: Ellis";
					label.color = new Color (0f,0f,255f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Kane> ().setAtive (true);
					turn = 4;
					camera1.enabled = false;
					camera2.enabled = true;
				}*/
				else {
					label.text = "Player 2: Ellis";
					label.color = new Color (0f,0f,255f);
					aluria.GetComponent<Aluria> ().setAtive (false);
					kane.GetComponent<Kane> ().setAtive (false);
					lilith.GetComponent<Lilith> ().setAtive (false);
					rayssa.GetComponent<Rayssa> ().setAtive (false);
					tarir.GetComponent<Tarir> ().setAtive (false);
					ellis.GetComponent<Ellis> ().setAtive (true);
                    ellis.GetComponent<Ellis>().resetPassos();
					turn = 0;
					camera1.enabled = false;
					camera2.enabled = true;
				}
			}
		}
        if (kane.GetComponent<Dano>().isDead() && rayssa.GetComponent<Dano>().isDead() && tarir.GetComponent<Dano>().isDead())
        {
            gameover.text = "GAME OVER: Player 2 Wins";
            gameover.color = new Color(0f, 0f, 255f);
        }
        else if(aluria.GetComponent<Dano>().isDead() && lilith.GetComponent<Dano>().isDead() && ellis.GetComponent<Dano>().isDead()) {
            gameover.text = "GAME OVER: Player 1 Wins";
            gameover.color = new Color(255f, 0f, 0f);
        }
	}
}


using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {
	
	private string titulo;
	private int larguraBotao;
	private int alturaBotao;
	
	public Inicio() {
		setTitulo("MENU PRINCIPAL");
		setLarguraBotao(200);
		setAlturaBotao(40);
		
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void setTitulo (string titulo) {
		this.titulo = titulo;
	}
	
	string getTitulo () {
		return titulo;
	}
	
	void setLarguraBotao (int larguraBotao) {
		this.larguraBotao = larguraBotao;
	}
	
	int getLarguraBotao () {
		return larguraBotao;
	}
	
	void setAlturaBotao (int alturaBotao) {
		this.alturaBotao = alturaBotao;		
	}
	
	int getAlturaBotao () {
		return alturaBotao;
	}
	
	void OnGUI(){
		GUI.Label (new Rect(Screen.width/2 - getLarguraBotao()/2 +40,10,200,200), getTitulo());
		
		if(GUI.Button(new Rect(Screen.width/2 - getLarguraBotao()/2,
		                       Screen.height/7 - getAlturaBotao()/7, getLarguraBotao(), getAlturaBotao()), "JOGAR")){
			Application.LoadLevel ("Done_Main");
		}
		if(GUI.Button(new Rect(Screen.width/2 - getLarguraBotao()/2,
		                       Screen.height/3 - getAlturaBotao()/3, getLarguraBotao(), getAlturaBotao()), "CONFIGURAÇOES")){
			Application.LoadLevel ("Configuracoes"); 
		}
		
		
		if(GUI.Button(new Rect(Screen.width/2 - getLarguraBotao()/2,
		                       142, getLarguraBotao(), getAlturaBotao()), "CREDITOS")){
			Application.LoadLevel("Creditos");
		}
		
	}
	
}


using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {
	private int larguraBotao;
	private int alturaBotao;
	private int larguraTexto;
	private string titulo;
	private string creditosDoJogo;
	
	
	public Creditos() {
		setLarguraBotao(200);
		setAlturaBotao(40);
		setLarguraTexto(50);
		setTitulo("CREDITOS");
		setCreditosDoJogo("========== CREDITOS ============");
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void setLarguraBotao(int larguraBotao) {
		this.larguraBotao = larguraBotao;
	}
	
	int getLarguraBotao() {
		return larguraBotao;
	}
	
	void setAlturaBotao(int alturaBotao) {
		this.alturaBotao = alturaBotao;
	}
	
	int getAlturaBotao() {
		return alturaBotao;
	}
	
	void setLarguraTexto(int larguraTexto) {
		this.larguraTexto = larguraTexto;
	}
	
	int getLarguraTexto() {
		return larguraTexto;
	}
	
	void setTitulo(string titulo) {
		this.titulo = titulo;
	}
	
	string getTitulo() {
		return titulo;
	}
	
	void setCreditosDoJogo(string creditosDoJogo) {
		this.creditosDoJogo = creditosDoJogo;
	}
	
	string getCreditosDoJogo() {
		return creditosDoJogo;
	}
	
	void OnGUI(){
		GUI.Label (new Rect(Screen.width /2 - getLarguraTexto()/2,10,200,200), getTitulo());
		
		GUI.Label (new Rect(Screen.width /2 - getLarguraTexto()/2,50,200,200), getCreditosDoJogo());
		
		
		if(GUI.Button(new Rect(Screen.width /2 - getLarguraBotao()/2,
		                       120, getLarguraBotao(), getAlturaBotao()), "VOLTAR")){
			Application.LoadLevel("Inicio");
		}
		
	}
}

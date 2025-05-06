using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CharacterStatusGeneric", menuName = "Status Gen�rico/Novo Inimigo")]
public class CharacterStatusGeneric : ScriptableObject
{
    public int for�a;
    public int defesa;
    public int vidaMaxima;
    public int vidaAtual;
    public List<Attack> ataques;
    
}

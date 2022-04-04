using System.Collections.Generic;
using UnityEngine;

public class InvadersSpawn : MonoBehaviour
{
    [SerializeField] private Invader[] _invadersPrefabs;
    [SerializeField] private int _rows = 5;
    [SerializeField] private int _columns = 11;
    [SerializeField] private float _widthSpacing = 2.0f;
    [SerializeField] private float _heightSpacing = 2.0f;
    [SerializeField] private PlayerScore _playerScore;
    [SerializeField] private GameStateManager _gameStateManager;

    private bool _isSpawnReady = false;
    private List<Invader> _invaders = new List<Invader>();

    public List<Invader> Invaders => _invaders;
    public bool IsSpawnReady => _isSpawnReady;

    public void Spawn()
    {
        float widthCenter = Center(_widthSpacing, _columns);
        float hieghtCenter = Center(_heightSpacing, _rows);

        for (int row = 0; row < _rows; row++)
        {
            float positionY = hieghtCenter + (row * _heightSpacing);
            int index = IndexPrefab();

            for (int column = 0; column < _columns; column++)
            {
                Invader invader = Instantiate(_invadersPrefabs[index], transform);
                _invaders.Add(invader);  
                float positionX = widthCenter + (column * _widthSpacing);
                Vector2 spawnPosition = new Vector2(positionX, positionY);
                invader.transform.localPosition = spawnPosition;
            }
        }
        _isSpawnReady = true; 
    }

    private int IndexPrefab()
    {
        return Random.Range(0, _invadersPrefabs.Length); 
    }

    private float Center(float size, float amount)
    {
        float result = size * (amount - 1);
        result = -result / 2; 
        return result; 
    }

    public void DeleteInvader(Invader invader) 
    {
        invader.gameObject.SetActive(false);
        _invaders.Remove(invader);
        _playerScore.ApplyScore(invader.Score);

        if (_invaders.Count == 0)
        {
            HaveNotInvaders();
        }
    }

    private void HaveNotInvaders()
    {
        _gameStateManager.FinishState();
    }

}

using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        Debug.Log("Game Start!");
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);

        direction = direction.normalized;

        if(Input.GetKey(KeyCode.W))
        {
        _playerTransform.Translate(Vector2.up * _speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
        _playerTransform.Translate(Vector2.down * _speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
        _playerTransform.Translate(Vector2.left * _speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
        _playerTransform.Translate(Vector2.right * _speed * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0)
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        Debug.Log("Planting Seed!");
        
        if (_numSeedsLeft > 0)      
        {
            GameObject plant = Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            
            Debug.Log("Plant position: " + _playerTransform.position);
            
            _numSeedsLeft--;
             
            _numSeedsPlanted++;
            
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            
        }
        else
        {
            Debug.Log("No seeds left to plant.");
        }
    }
}

// SNIPPETS





///input easy
        private void Update()
        {
#if UNITY_EDITOR

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                AButtonPress();
            }
#endif
        }


/*
NAMING

1. Public Variables

    PascalCase: Public variables are typically named using PascalCase. This means that each word in the name starts with a capital letter.
    Example: public int Health;, public float MovementSpeed;, public GameObject PlayerObject;

2. Private Variables

    camelCase with _ Prefix: Private variables are often named using camelCase with an optional underscore (_) prefix. The underscore helps to differentiate private fields from local variables or method parameters.
    Example: _health, _movementSpeed, _playerObject

3. Serialized Private Variables

    camelCase with _ Prefix: When a private variable is serialized (using [SerializeField]), it typically follows the same naming convention as regular private variables: camelCase with an underscore prefix.
    Example: [SerializeField] private int _health;, [SerializeField] private float _movementSpeed;


*/
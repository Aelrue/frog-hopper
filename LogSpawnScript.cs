   // Start is called before the first frame update
    void Start()
    {
        spawnLog();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        { timer = timer + Time.deltaTime; }
       else {
            spawnLog();
            timer = 0;
        }
    }
    void spawnLog()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(log, new Vector3 (transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}

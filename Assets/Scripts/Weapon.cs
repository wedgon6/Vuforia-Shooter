using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _shootPoit;
    [SerializeField] private Bullet _bulletTemplate;

    public void Shoot()
    {
        Instantiate(_bulletTemplate,_shootPoit.position,transform.rotation);
    }
}

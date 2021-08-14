using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : HouseController
{
    /*
    НУЖНО ИСПРАВИТЬ БАГ, ПРИ КОТОРОМ  gravityScale != 4 У ТОГО ДОМА, КОТОРЫЙ ДОЛЖЕН УПАСТЬ. ЭТО ПРИВОДИТ К ТОМУ, ЧТО ПРИ ПОЯВЛЕНИИ НОВЫХ ДОМОВ, ОНИ ВСЕ ВЫСТРАИВАЮТСЯ В ОДНУ ЛИНИЮ
    ТАКЖЕ, ПОЧЕМУ-ТО, КОГДА ГРАВИТАЦИЯ > 0 ДОМ ВСЕ РАВНО ДВИГАЕТСЯ ПО НЕБОЛЬШОЙ ДИАГОНАЛИ ВНИЗ
    */
    

    [SerializeField] private GameObject housePrefab;
    private void Start() {
        CreateHouse();
    }

    private void Update() {
        IsSpaceButtonDown();
    }

    private void CreateHouse() {
        Instantiate(housePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        HouseController.isGrounded = false;

    }

    private void IsSpaceButtonDown() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnHouse();
        }
    }

    private void SpawnHouse() {
        HouseController.isGrounded = true;
        rb2d.gravityScale = 4;
        CreateHouse();
    }
}

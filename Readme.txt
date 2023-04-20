# EntekhabGroup

Description:https://github.com/aliakbarpoor/EntekhabGroup/blob/master/EntekhabGroup%20-%20Microsoft%20Visual%20Studio%202023-04-11%2018-26-01.mp4

1 .Download Project from github
https://github.com/aliakbarpoor/EntekhabGroup.git

2. Open Project(.net7)
3. Opne package manager console 
4. set default peoject to "Insfrastructure" > Rum Command Update-Database
5. Set Defalt Project to API
6. Run Project

http://localhost:54325/swagger/index.html



## Postman Export

{
	"info": {
		"_postman_id": "6204e049-324c-4afb-8ed8-b8de95634f10",
		"name": "EntekhabGroup",
		"schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json",
		"_exporter_id": "8061857"
	},
	"item": [
		{
			"name": "Add-custom",
			"request": {
				"method": "POST",
				"header": [
					{
						"key": "Content-Type",
						"value": "text/custom",
						"type": "text"
					}
				],
				"body": {
					"mode": "raw",
					"raw": "{\r\n    \"Data\":\"FullName/BasicSalary/Allowance/Transportation/Date/OverTime\r\n            Ali Akbarpour/50000000/1000000/500000/14010118/40\",\r\n     \"OverTimeCalculator\":\"CalculatorA\"         \r\n}\r\n\r\n",
					"options": {
						"raw": {
							"language": "text"
						}
					}
				},
				"url": {
					"raw": "http://localhost:54325/custom/salary/add",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "54325",
					"path": [
						"custom",
						"salary",
						"add"
					]
				}
			},
			"response": []
		},
		{
			"name": "Add-json",
			"request": {
				"method": "POST",
				"header": [
					{
						"key": "Content-Type",
						"value": "application/json",
						"type": "text"
					}
				],
				"body": {
					"mode": "raw",
					"raw": "{\r\n    \"Data\":{\"FullName\":\"Ali Akbarpour\",\"BasicSalary\":\"50000000\",\"Allowance\":\"1000000\",\"Transportation\":\"500000\",\"OverTime\":\"40\" },\r\n     \"OverTimeCalculator\":\"CalculatorA\"         \r\n}\r\n\r\n"
				},
				"url": {
					"raw": "http://localhost:54325/json/salary/add",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "54325",
					"path": [
						"json",
						"salary",
						"add"
					]
				}
			},
			"response": []
		},
		{
			"name": "Get",
			"request": {
				"method": "GET",
				"header": [],
				"url": {
					"raw": "http://localhost:54325/json/salary/get/2",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "54325",
					"path": [
						"json",
						"salary",
						"get",
						"2"
					]
				}
			},
			"response": []
		},
		{
			"name": "Delete",
			"request": {
				"method": "DELETE",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\"Id\":\"7\",\"FullName\":\"Ali Akbarpour\",\"BasicSalary\":\"50000000\",\"Allowance\":\"1000000\",\"Transportation\":\"500000\",\"OverTime\":\"40\" }",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "http://localhost:54325/json/salary/delete",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "54325",
					"path": [
						"json",
						"salary",
						"delete"
					]
				}
			},
			"response": []
		},
		{
			"name": "Update",
			"request": {
				"method": "PUT",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\"Id\":\"3\",\"FullName\":\"Ali Akbarpour\",\"BasicSalary\":\"50000000\",\"Allowance\":\"1000000\",\"Transportation\":\"500000\",\"OverTime\":\"30\",\"Date\":\"1402/01/18\"}",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "http://localhost:54325/json/salary/update",
					"protocol": "http",
					"host": [
						"localhost"
					],
					"port": "54325",
					"path": [
						"json",
						"salary",
						"update"
					]
				}
			},
			"response": []
		}
	]
}

















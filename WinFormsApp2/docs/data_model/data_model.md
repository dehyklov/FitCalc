# Модель даних FitCalc

| Назва сутності | Атрибути | Тип даних |
| :--- | :--- | :--- |
| **User** | id, name, weight, age | Integer, String, Float, Integer |
| **Exercise** | id, title, met_factor | Integer, String, Float |
| **Calculation** | id, user_id, exercise_id, result, date | Integer, FK, FK, Float, DateTime |
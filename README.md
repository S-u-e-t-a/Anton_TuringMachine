Эмулятор машины Тьюринга. ver. 2.08

Автор: Гусев Антон, группа 494, СПбГТИ(ТУ)

Для начала работы необходимо:
- указать количество свободных ячеек на ленте необходимых для Вашей программы и нажать кнопку "Готово"
- после уже введённой * в графе алфавит указать те символы, которые будут использоваться Вами в программе
- после чего необходимо ввести данные на ленту после звёздочек и нажать кнопку "Ввести ленту"

Кнопки "Вперед" и "Назад" перемещают указатель активной ячейки по ленте. Установите этот указатель в необходимое для Вашей программы место.

Далее необходимо ввести текст программы в таблицу состояний. Примеры и правила кода приведены ниже.
После этого, нажимая кнопку "Шаг", выполните программу.

Если Вы хотите ввести ленту заново нажмите стереть ленту. Пустые ячейки подставятся автоматически.
Если Вы хотите изменить количество пустых ячееки - выберите меню файл далее пункт перезапуск.

Внимание! При этом эмулятор полностью перезапустится

Примеры и правила кода:
Команда состоит из 3-х частей: 

- В какое состояние должна перейти программа после выполнения текующей команды (1 - q1, 2 - q2 и т.д.)
- В каком направлении сдвигается указатель по ленте после выполнения команды (L - влево, R - вправо, H - останов)
- На что необходимо заменить текущее значение ячейки ленты (из алфавита)

ЧАСТИ КОМАНДЫ РАЗДЕЛЯЮТСЯ ПРОБЕЛОМ!

Примеры:
- 1 R 2 - перейти к состоянию q1, свдвинуться по ленте вправо, заменить текущее значение на "2"
- 3 L * - перейти к состоянию q3, свдвинуться по ленте влево, заменить текущее значение на "*"
- 4 H * - остановка машины

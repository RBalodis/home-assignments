JavaScript jQuery:

- Есть ли разница в значениях переменных foo и bar?

<span class="my-test" data-cost="800">This is your test</span>

<script>
var foo = jQuery('span.my-test').attr('data-cost');
var bar = jQuery('span.my-test').data('cost');
</script>

- Какой результат будет при сравнении типов данных и почему?

- Почему если мы изменим таким образом

jQuery('span.my-test').data('cost', 900);
foo будет "800", а bar 900?

- Есть ли ошибка в коде?

var Monkey = {
me: function() {return this},
body: () => this,
say: console.log
};

- Какой получим результат и почему?

Monkey.body().say('Hello');

PHP Laravel:

Написать свой Laravel Middleware, который можно добавить в список Routes.
Он должен проверять присутствие в параметре GET version=2.
Если такого параметра не будет, возвращать JSON со структурой {"error": "такой версии не существует"}
Приложить Middleware и пример его подключения к Route.

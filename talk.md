Talk title
=============================

![](resources/logo.svg)

* Your name
* Date, etc

Note:
Anything after Note will be taken as part of the speaker notes. Super useful.
Remember that pressing the `S` key you get the notes.
___

## Agenda

* a
* b
* c

---

## First section

> You can use your good markdown

<blockquote>
	but also HTML!
</blockquote>
___

## Sub-topic

Some code

```sql
CREATE OR REPLACE FUNCTION zoom(scaledenominator numeric)
RETURNS integer
AS $$
BEGIN
	CASE
		WHEN scaleDenominator > 1000000000
			THEN RETURN 0;
		WHEN scaleDenominator <= 1000000000 AND scaleDenominator > 500000000
			THEN RETURN 1;
		WHEN scaleDenominator <= 500000000 AND scaleDenominator > 200000000
			THEN RETURN 2;
		WHEN scaleDenominator <= 200000000 AND scaleDenominator > 100000000
			THEN RETURN 3;
		...
		WHEN scaleDenominator <= 100
		THEN RETURN 23;
	END CASE;
END;
$$ language 'plpgsql';
```

---

## Second section
<!-- .slide: data-background="red" -->

<iframe
	src="https://team.cartodb.com/u/jsanz/viz/2d2dbc20-0b3f-11e6-abc3-0ecd1babdde5/embed_map"
	frameborder="0"
	style="width:100%;height:500px;"
>
</iframe>

___

## Another subtopic

* A bullet list <!-- .element: class="fragment" -->
* With elements <!-- .element: class="fragment" -->
* Shownig after click <!-- .element: class="fragment" -->

___

<!-- .slide: data-background="resources/callao_background.jpg" -->

<div style="padding:25px;background-color:#2d3b42;">
<h1>A slide with a custom background!!</h1>
</div>

Cultivating the right problem solving skills
=============================

---

![](resources/logo.svg)

* Wouter Groeneveld
* Techorama date

___

## Agenda

* Why are we talking about **obvious things**?
* How to **acknowledge** you're in for it
* How to **find** problems?
* How to '**fix**'' them?
* Going **beyond** your fix

Including demo's.

---

## Why talk about problem solving?

> Did you try turning it on and off again?

Or:

> Are you sure it's plugged in?

___

Good coders know what they're doing...

![](resources/try.jpg)

___

## If it's that obvious...

Then **why aren't we doing it**?

**Don't lie to yourself**!

<br/>

I'm doing it wrong

And so are you (probably)

___

## Fear of ...

 * Being under time pressure
 * Not knowing what to do
 * Not wanting others to know what you (don't) know
 * ...

[Wanna create a great product?](https://www.fastcodesign.com/1663968/wanna-create-a-great-product-fail-early-fail-fast-fail-often)

> Fail early, fail often.

___

## Definition of problem solving

> the process of finding solutions to difficult or complex issues.

For us software developers:

> Getting things done.

---

## Do we even have a problem?

I know I don't! 

<br/>
It's called being **Irresponsible**. 

It might be a bliss.

___

## The Responsibility Model

[By Christopher Avery](https://www.christopheravery.com/responsibility-process)

  * <span style="color: lightblue;">Responsibility</span>
  * <span style="color: lightgreen;">Obligation</span> <span style="color: grey;">(Quit)</span>
  * <span style="color: lightgreen;">Shame</span>
  * <span style="color: red;">Justify</span>
  * <span style="color: red;">Lay Blame</span>
  * <span style="color: grey;">Denial</span>

Bottom -> Top. 
___
<!-- .slide: data-background="#85ba62" -->
## Take one for the team!

---

## How to find problems

___

### Get to know your tools!

(Remote) Debugging, Call stack, Breakpoints, (Network) tracing, ...

![](resources/debugging.png)

___

### Stuck? Try the rubber duck!

![](resources/rubberducky.jpg)

___

### Stuck? Try brainstorming

Write down **at least 5 different** approaches to the problem. 

Don't worry about the <i>feasibility</i>.

By **yourself** or **with others**: use the whiteboard! 

___

### Stuck? Try pair programming

![](resources/pairprogramming.jpg)

Book: [Extreme Progrmaming Explained](https://www.amazon.com/Extreme-Programming-Explained-Embrace-Change/dp/0321278658)

___

### Stuck? Try a toilet break

![](resources/toiletbreak.jpg)

___

### Stuck & angry? Try mindfulness

Calmness VS angryness. <br/>
It won't help you find what you're looking for!

Book: [Search Inside yourself](https://www.amazon.com/Search-Inside-Yourself-Unexpected-Achieving/dp/0062116932) By Chade-Meng Tan

___

```javascript
 var tree = Ext.getCmp('forum-tree');
    tree.on('append', function(tree, p, node){
       if(node.id == 40){
           node.select.defer(100, node);
       }
    });
    var sm = tree.getSelectionModel();
    sm.on('beforeselect', function(sm, node){
         return node.isLeaf();
    });
    sm.on('selectionchange', function(sm, node){
        ds.loadForum(node.id);
        Ext.getCmp('main-view').setTitle(node.text);
    });

Forum.TreeLoader = function(){
    Forum.TreeLoader.superclass.constructor.call(this);
    this.proxy = new Ext.data.ScriptTagProxy({
        url : this.dataUrl
    });
};
```

> Woah that's crap code! What the f***

Getting angry? Or do you happen to like JS?
___

![](resources/Chade.jpg)

---

## How to fix problems

Are you sure it's fixed? 

> Dear customer, we modified some code. Please try again and let us know if it worked. Regards.

Sounds professional to you? 
___

### Use unit tests

Get rid of regression! 

![](resources/tdd.png)

___

### Use unit tests

 * But... I don't have time!
 * But... I'm working with legacy code I can't get into a test harnass!
 * But... It's frikkin' (Stored procs, VB6, ...)! What now? 
 * But but but... 

___

### But... I don't have time!

Use sprints. **Estimate stuff**. 

Educate your manager(s) on how much time it costs. <br/>
Short-term VS long-term (1)

___

### But... I'm working with legacy code!

Yeah. So? 

Book: [working effectively with legacy code](https://www.amazon.com/Working-Effectively-Legacy-Michael-Feathers/dp/0131177052) by Michael C. Feathers.

![](resources/legacycode.jpg)

___

### But... It's frikkin' (Stored procs, VB6, ...)! 

Yeah. So?

[SimplyVBUnit](http://simplyvbunit.sourceforge.net/)

![](resources/simplyvbunit.png)
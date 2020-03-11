What is RAWr ?

This is a (piece of shit) software that allow you to sort and copy to a folder RAW files.

____________

Can I look at the code ?

Sure, you can piss yourself laughing just here : https://github.com/kouglov/rawr

____________

How does it works ?

Start by organising your files. You'll need them in sub-folders.
Gather all the sub-folers into a unique directory so that the architecture looks like this : 

[INPUT FOLDER]
	|
	|
	|----[Folder 1]
	|        |
	|        |-- 1.dng
	|        |-- 2.dng
	|        |-- 3.dng
	|
	|
	|----[Folder 2]
	|        |
	|        |-- A.dng
	|        |-- B.dng
	|        |-- C.dng
	
Then, select the Input Folder, and choose another Output folder.

You're ready ! navigate between pics with your left and right arrow keys on your keyboard.
When you finish a folder, you automatically crawl the next folder.

When you want to copy a RAW inside the Output folder, simply press 'S'

The red square on the top-left of the window will pass to green. 
You'll know if you already copied this pic when you come back !

____________

What does it read ? 

Many RAW format, including DNG, CR2 and NEF (NEF wasn't tested)

____________


Does it read *** files ?

Sure, you add the functionnality and then you're good.


____________

It's very slow in loading and there is no loading bar

Yes. Let me explain why.
It's not a production software. It's a tool that I created for a unique purpose : 

"being able to sort and copy DNG files wich are shot by a 6D Canon Camera with Magic Lantern, 
 in 2.35 format wich is 1824 x 776 pixels"
 
That's it.

It wasn't designed to do something else, especially load some 8k per 6k pixels RAW. That's not the point.

The point is : converted DNG from Magic Lantern have only a 128 pixel height thumbnail wich is impossible to look at when selecting the shots I want.
So I created the tool.
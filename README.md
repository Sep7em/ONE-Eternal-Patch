ONE Eternal Patch v2.0
======

About
---------

ONE Eternal Patch is a patch for the visual novel ONE \~Kagayaku Kisetsu e\~.<br/>
The goal of this patch is to create an enhanced experience by implementing the new content introduced in the PS1 version of the novel.<br/><br/>
As of right now this patch :<br/>
- Ports Natsuki's route in Japanese and English (Spanish translation ongoing)<br/>
- Adds the new PS1 CGs<br/>
- Allows you to partially remove the H-scenes<br/>
- Fixes some minor glitches

Future releases will allow players to fully remove H-scenes and will add cool things in the Extra menu.

How to use it?
---------

1. Launch the "ONE_Eternal_Patch_v2.0.exe" file.<br/>
2. Select the path of the game.<br/>
3. Select the language and edition you're using and the content you want to have.<br/>
4. Click on the Patch button.

NOTE THAT THE ETERNAL PATCH ISN'T A TRANSLATION PATCH. If you want to have the new content in English, Spanish or Chinese, you need first to apply the corresponding translation patch and then to apply the Eternal Patch.

How to know the edition I am using?
---------

Open the directory of the game, if you've files named:<br/>
- "One.exe", "one" and "one.lst" then you're using the Full Voice Edition<br/>
- "lcsebody.exe", "lcsebody1" and "lcsebody1.lst" then you're using the Vista Edition<br/>
- "One_cn.exe", "one_cn" and "one_cn.lst" then you're using the Chinese translation (with the Full Voice or Vista Edition but it's not important to know the edition with this translation)

Saves
---------

The Eternal Patch adds all sorts of data into the game and your old saves aren't planned to work with them. Thankfully, the patch converts them when you're patching the game!

If you don't have saves to convert or you don't care about them, make sure that there isn't any save in your sav folder before launching the game. New saves compatible with the changes made by the patch will automatically be created by the game.

When the Vista Edition is installed, it stores the saves in:<br/>
C:\Users\\******\AppData\Local\VirtualStore\Program Files (x86)\nexton\one_fv\sav (replace the ****** by the current user name)<br/>
However if the game can't find this sav folder or if the game's directory has been moved elsewhere then it'll store the saves in the sav folder inside the game's directory.<br/>
The Eternal Patch first checks if there's a sav folder inside the game's directory and if it's the case it'll attempt to convert the saves inside. If it's not the case, it'll try to convert the saves inside the user sav directory. Be mindful of this if you've any problem with the save conversion.

It's possible that you get a message during the conversion telling you that some of the saves were made after changes made by the patch. For example, if you've a save that was made just after the first encounter with Nanase then your save doesn't reference the same position in the Day 1 script anymore since there are new CGs in this scene. It's possible that such a save references a line in a script that isn't supposed to be loaded when you're using the load function and it can have negative effects on the game.<br/>
It's better to not use these saves anymore however if you really want to use them I recommend to load your save, click on the screen to pass on the next text, save on the same save slot, quit the game and then load your new save, that should reduce the chances to encounter any problem related to the save.

If you get the error message "アクセスバイオレーションしてます><" while reading texts from Natsuki's route it means that the saves you're using have not been converted. Note that using an unconverted global save (SAVE__.LCS) with a patched version of the game will corrupt it (noticeable as the right click menu will stop working properly). Also note that the converted saves will not work properly with an unpatched version of the game anymore, use the saves created in the backup folder instead.

Compatibility
---------

This patch is compatible with the Full Voice Edition and the Vista Edition of the game, it works with the Japanese version and the English, Spanish and Chinese translations.

It shouldn't be necessary to know since the translation patches haven't got any update since a very long time but here are the versions I've used for each of them if you want to know:<br/>
English: Version 1.5<br/>
Spanish: Version 1.3<br/>
Chinese: Version 1.0 (Famille Hanhuazu)

I haven't added a compatibility with the Korean patch yet since it's a difficult patch to work with and since it doesn't seem to be finished but it'll be done eventually.<br/>
The Eternal Patch isn't compatible with the old Chinese patch made by the Key Fans Club as I can't find it online and since the newer patch seems better.

Glitches being fixed
---------

The patch fixes a few minor glitches present in the gallery:<br/>
- Mio had a headpat CG that you weren't able to see because the developers forgot a few lines of code<br/>
- Nanase had some CG miniatures that had a 1 pixel white line because of the way they were disposed in the assets<br/>
- In the Spanish translation, Mayu's name was written in Japanese because the devs didn't name one of the files correctly

Note that these glitches are only fixed if you apply at least one of the changes brought by the Eternal Patch.<br/>

FAQ
---------

Where can I find a walkthrough of Natsuki's route?<br/>
I've made one here:<br/>
https://pastebin.com/rM30H6JR

Why the patch removes the H-scenes only partially?<br/>
This patch completely removes the H-scenes from the routes of Akane and Mio and it also removes all the HCGs from the gallery.<br/>
The H-scenes in the 4 other routes are mandatory to get the true ending of each route that's why removing them is harder. The PS1 edition of the game makes a lot of little changes in the story to make their removing coherent with the story and I need to port these changes to remove the H-scenes completely. For the moment, I've replaced all the HCGs by black screens so you'll not see any sexual content but you'll still have to read some.

Where does the new CGs come from?<br/>
All the CGs were extracted from the second CD of the Limited Edition of ONE, so they're in HQ (640x480 instead of the compressed 640x240 CGs of the first CD). However, I needed to take Natsuki's sprites and the background CG of Misaki's house from the first CD, I used waifu2x to make them look nicer.

I've seen a new CG but it's not unlocked in the gallery?<br/>
It's normal. It's because for the longest time I didn't know how to create new CG IDs so the new CGs that aren't Natsuki are unlocked when you see the next obligatory CG that you see in the route concerned. This problem should be resolved in the upcoming 2.1 version of the patch.

It is planned to translate Natsuki's route into other languages?<br/>
A Spanish translation is ongoing. Contact me if you're interested to translate the route into Chinese or Korean.

Author
------
Patch developed by Sep7.<br/>
Thanks to Tigoris for having accepted the commission of the English translation of Natsuki's route.<br/>
Thanks to Draconyan for the proofreading.<br/>
Thanks to Sandman for his opinion on some changes.<br/>
Thanks to the developers of GARbro to let me use parts of their code.<br/>
Thanks to Lucia for having shared with me an ISO of the Vista Edition, allowing me to make the patch compatible with it.

Servers
---------

If you want to ask questions about the patch or just want to have fun with fans of Tactics and Key, join the Tactics Discord server:
https://discord.gg/XUfvN2p <br/>
Spoilers are only allowed in specific channels of the server so you'll not be spoiled about anything. It's also here that I'll post the progress of this patch.

You can also join the Keyverse server if you want more Tactics/Key fun!<br/>
https://discord.gg/mFbZD7rwRb

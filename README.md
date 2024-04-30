<div align = center>

![](https://raw.githubusercontent.com/DmitryHudrich/Winter/new-readme-draft/Assets/header.gif)

![Badge Pull Requests] 
![Badge Issues]
![Badge Hi Mom]
[![chatroom icon](https://patrolavia.github.io/telegram-badge/chat.png)](https://t.me/+O_QwU8ifzcdkNmE6)
<br>
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![React](https://img.shields.io/badge/react-%2320232a.svg?style=for-the-badge&logo=react&logoColor=%2361DAFB)
![TypeScript](https://img.shields.io/badge/typescript-%23007ACC.svg?style=for-the-badge&logo=typescript&logoColor=white)

<br>

This innovative tool seamlessly integrates your daily work applications into a single platform. It serves as the comprehensive workspace for both you and your team.
> Winter will bring together strangers with similar interests, as winter used to bring together unfamiliar travelers in different huts

---

# ❄️ What's Winter?

</div>
Our team, Winter developers, wants to make a flexible, user-friendly and cloud-oriented solution for creating beautiful notes, articles, knowledge bases to group your clutter in one place, like chaotic snowflakes that eventually add up to one beautiful snow shroud.
Winter will allow you to organize your ideas and plans in the form of flexible but simple records. having the ability to refer to others in one entry, you form a whole system of notes. there may be several such systems, each of which contains entries on a specific topic, it may be:

- your personal knowledge base, marked as private and accessible only to you;
- documentation on your project, accessible only to those people to whom you have given access to it;
- the history of the world, your book, accessible to everyone so that everyone can explore your world closer.

### 🌟 brief description of the functions:
- creating knowledge bases;
- defining privacy settings for knowledge bases; 
- using the markdown format for easy creation of notes;
- the ability to share knowledge bases and edit individual documents at the same time;
- etc...

It is planned that our project will have open source code and the ability to deploy winter locally. It is possible that winter will work in a decentralized manner. Web 3.0?

## 🐳 Easy start with docker
### Requerments  
- docker compose
### Launch
- clone repo:

  ```
  git clone https://github.com/DmitryHudrich/Winter.git
  ```

- go to repo directory:
  
  ```
  cd ./Winter
  ```

- start a cluster:

  ```
  docker compose -f docker-compose.dev.yml up
  ``` 

- congrats! ^^

## 🛠️ Without docker
### Requirments:
- nodejs
- npm
- dotnet-sdk 8.0
### Launch
- clone repo:
  
  ```
  git clone https://github.com/DmitryHudrich/Winter.git
  ```

- go to repo directory:
  
  ```
  cd ./Winter
  ```

- start a server:
  
  ```
  dotnet run -c Release --project  ./ServerApp/ServerApp.Api
  ```

- install node.js dependencies:

  ```
  npm i ./ClientApp 
  ```

- start client:
  
  ```
  npm run --prefix ./ClientApp dev 
  ```

- congrats!

# 🎁 Contributing to Winter
Thank you for your interest in contributing to Winter!
You have several ways to contribute.
- ### Github issues
  Did you find a bug? Don't like how something works? Do you want to suggest a new feature? Github issues is a great way to talk about it and we will be happy to consider all suggestions.
- ### Pull requests
  We have some simple recommendations about pull requests:
  - one feature — one pull request;
  - *clearly* describe the essence of the changes;

**Thank you for your help!**

<br/><br/>
⋆꙳•❅*°⋆❄️.ೃ࿔*:･*❄️ ₊⋆꙳•❅*°⋆❄️.ೃ࿔*:･*❄️ ₊⋆⋆꙳•❅*°⋆❄️.ೃ࿔*:･*❄️ ₊⋆꙳•❅*°⋆❄️.ೃ࿔*:･*❄️ ₊⋆⋆꙳•❅*°⋆❄️.ೃ࿔*:･*❄️ ₊⋆꙳•❅*°⋆❄️.ೃ࿔*:･*❄️ ₊⋆⋆꙳•
```
   .      .          
   _\/  \/_       _   _  _ __  _ _____ ___ ___
    _\/\/_       | | | || |  \| |_   _| __| _ \ 
_\_\_\/\/_/_/_   | 'V' || | | ' | | | | _|| v / 
 / /_/\/\_\ \    !_/ \_!|_|_|\__| |_| |___|_|_\
```

<!----------------------------------{ Badges }--------------------------------->

[Badge Issues]: https://img.shields.io/github/issues/DmitryHudrich/Winter
[Badge Pull Requests]: https://img.shields.io/github/issues-pr/DmitryHudrich/Winter
[Badge Language]: https://img.shields.io/github/languages/top/DmitryHudrich/Winter
[Badge Lines]: https://img.shields.io/tokei/lines/github/hyprwm/DmitryHudrich/Winter
[Badge Hi Mom]: https://img.shields.io/badge/Hi-mom!-ff69b4


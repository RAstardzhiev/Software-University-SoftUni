function wikiParser(selector) {
    let paragraphs = $('p' + selector);

    let parserFunctions = {
        bold: (str) => str.replace(/'''([^']+)'''/gm, (m, g1) => `<b>${g1}</b>`),
        italics: (str) => str.replace(/''([^']+)''/gm, (m, g1) => `<i>${g1}</i>`),
        h3: (str) => str.replace(/===([^=]+)===/gm, (m, g1) => `<h3>${g1}</h3>`),
        h2: (str) => str.replace(/==([^=]+)==/gm, (m, g1) => `<h2>${g1}</h2>`),
        h1: (str) => str.replace(/=([^=]+)=/gm, (m, g1) => `<h1>${g1}</h1>`),
        linkWithoutText: (str) => str.replace(/\[\[([^|\[\]]+?)\]\]/gm, (m, g1) => `<a href="/wiki/${g1}">${g1}</a>`), 
        linkWithGivenText: (str) => str.replace(/\[\[(.+?)\|(.+?)\]\]/gm, (m, g1, g2) => `<a href="/wiki/${g1}">${g2}</a>`)
    }

    for (let i = 0; i < paragraphs.length; i++) {
        let text = $(paragraphs[i]).text();

        text = parserFunctions.bold(text);
        text = parserFunctions.italics(text);
        text = parserFunctions.h3(text);
        text = parserFunctions.h2(text);
        text = parserFunctions.h1(text);
        text = parserFunctions.linkWithoutText(text);
        text = parserFunctions.linkWithGivenText(text);

        $(paragraphs[i]).html(text);
    }
}
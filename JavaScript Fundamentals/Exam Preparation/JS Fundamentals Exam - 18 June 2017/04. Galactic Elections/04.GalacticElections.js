function printWinner(input) {
    let systems = new Map();
    let totalVotes = 0;

    for (const line of input) {
        let currentSystem = systems.get(line.system);
        if (!currentSystem) {
            systems.set(line.system, new Map());
            currentSystem = systems.get(line.system);
        }

        let currentCandidateVote = currentSystem.get(line.candidate);
        if (!currentCandidateVote) {
            currentCandidateVote = line.votes
        } else {
            currentCandidateVote += line.votes;
        }

        currentSystem.set(line.candidate, currentCandidateVote);
        totalVotes += line.votes;
    }

    let result = '';
    let winners = determineWinnersPerSystem();
    let firstWinnerTotalVote = winners
        .filter(w => w.candidate === winners[0].candidate)
        .map(w => w.votes)
        .reduce((a, b) => a + b);

    if (isUnopposedWinner()) {
        let allVotes = winners.map(w => w.votes).reduce((a, b) => a + b);

        result = `${winners[0].candidate} wins with ${allVotes} votes\n` +
            `${winners[0].candidate} wins unopposed!`;
    } else if (firstWinnerTotalVote >= totalVotes / 2) {
        result = `${winners[0].candidate} wins with ${firstWinnerTotalVote} votes\n`;

        let secondPlaceName = winners[1].candidate;
        result += `Runner up: ${secondPlaceName}\n`;
        result += winners
            .filter(s => s.candidate === secondPlaceName)
            .map(s => `${s.sysName}: ${s.votes}`)
            .join('\n');
    } else {
        result = `Runoff between ` +
            `${winners[0].candidate} with ` +
            `${Math.floor(winners.filter(s => s.candidate === winners[0].candidate).map(s => s.votes).reduce((a, b) => a + b) / totalVotes * 100)}% and ` +
            `${winners[1].candidate} with ` +
            `${Math.floor(winners.filter(s => s.candidate === winners[1].candidate).map(s => s.votes).reduce((a, b) => a + b) / totalVotes * 100)}%`;
    }

    console.log(result);

    function isUnopposedWinner() {
        let firstWinnerName = winners[0].candidate;

        for (let i = 1; i < winners.length; i++) {
            if (winners[i].candidate !== firstWinnerName) {
                return false;
            }
        }

        return true;
    }

    function determineWinnersPerSystem() {
        let winners = [...systems]
            .map(s => {
                return {
                    sysName: s[0], candidate: [...s[1]].map(c => {
                        return {
                            name: c[0], votes: c[1]
                        }
                    })
                        .sort((a, b) => b.votes - a.votes)
                }
            });;

        for (let i = 0; i < winners.length; i++) {
            let totalVotesInCurrentSystem = winners[i].candidate
                .map(c => c.votes)
                .reduce((a, b) => a + b);

            winners[i].candidate = winners[i].candidate[0].name;
            winners[i]['votes'] = totalVotesInCurrentSystem;
        }

        return winners.sort((a, b) => b.votes - a.votes);
    }
}

// // Test 5
// printWinner(
//     [{ system: 'Theta', candidate: 'Kitler', votes: 50 },
//     { system: 'Theta', candidate: 'Space Cow', votes: 45 },
//     { system: 'Theta', candidate: 'Huge Manatee', votes: 45 },
//     { system: 'Theta', candidate: 'Flying Shrimp', votes: 45 },
//     { system: 'Tau', candidate: 'Kitler', votes: 50 },
//     { system: 'Tau', candidate: 'Space Cow', votes: 60 },
//     { system: 'Sigma', candidate: 'Kitler', votes: 50 },
//     { system: 'Sigma', candidate: 'Huge Manatee', votes: 60 },
//     { system: 'Omicron', candidate: 'Kitler', votes: 50 }]
// );

// // Test 2
// printWinner(
//     [{ system: 'Tau', candidate: 'Flying Shrimp', votes: 150 },
//     { system: 'Tau', candidate: 'Space Cow', votes: 100 },
//     { system: 'Theta', candidate: 'Space Cow', votes: 10 },
//     { system: 'Sigma', candidate: 'Space Cow', votes: 200 },
//     { system: 'Sigma', candidate: 'Flying Shrimp', votes: 75 },
//     { system: 'Omicron', candidate: 'Flying Shrimp', votes: 50 },
//     { system: 'Omicron', candidate: 'Octocat', votes: 75 }]
// );

// Test 1
printWinner(
    [{ system: 'Theta', candidate: 'Flying Shrimp', votes: 10 },
    { system: 'Sigma', candidate: 'Space Cow', votes: 200 },
    { system: 'Sigma', candidate: 'Flying Shrimp', votes: 120 },
    { system: 'Tau', candidate: 'Space Cow', votes: 15 },
    { system: 'Sigma', candidate: 'Space Cow', votes: 60 },
    { system: 'Tau', candidate: 'Flying Shrimp', votes: 150 }]
);


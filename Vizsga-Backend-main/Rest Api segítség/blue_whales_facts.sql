
-- Create the database (optional, depending on the system)
-- CREATE DATABASE blue_whales;

-- Use the database (optional)
-- USE blue_whales;

-- Create the table
CREATE TABLE whale_facts (
    id INT PRIMARY KEY,
    question_code CHAR(1),
    question_text TEXT,
    answer_text TEXT
);

-- Insert the data
INSERT INTO whale_facts (id, question_code, question_text, answer_text) VALUES
(1, 'A', 'What age do blue whales reach on average?', 'They are believed to live around 80 to 90 years. Although the oldest blue whale measured was estimated to be around 110 years.'),
(2, 'C', 'Do they have huge teeth like sharks – is that how they catch their prey?', 'Actually, they have a unique way of feeding. They take a huge amount of water into their mouth and then they push the water out through baleen plates. The water is forced out while the krill stay behind and are swallowed by the whales.'),
(3, 'D', 'Are they sociable creatures?', 'It might appear that they are not as they are usually seen swimming alone or in pairs. However, we do see them swimming in small groups and of course they are well-known for their complex way of communicating with each other, suggesting that in fact they are.'),
(4, 'E', 'Is it true that blue whales are the largest animals on Earth?', 'Yes, they can be up to 30 metres long and weigh more than 200 tons. Did you know that a whale’s tongue on its own weighs as much as an elephant?'),
(5, 'F', 'How about predators, do they have any?', 'They have very few. Occasionally they may be attacked by sharks or killer whales. Of course, they are also injured or killed each year when large ships accidentally crash into them and whale hunting still happens in some parts of the world. Blue whales are considered to be an endangered species.'),
(6, 'G', 'How did they calculate its age?', 'Scientists can find the approximate age of a blue whale after it dies, by counting how many layers of earplugs it has.'),
(7, 'H', 'What do blue whales feed on?', 'They have a diet of krill, which are tiny animals like shrimp. At some points in the year they consume up to 4 tons a day!'),
(8, 'I', 'Can you tell us more about that?', 'Actually, they have a unique way of feeding. They take a huge amount of water into their mouth and then they push the water out through baleen plates. The water is forced out while the krill stay behind and are swallowed by the whales.'),
(9, 'J', 'Where can blue whales be found?', 'Blue whales live in all seas. In the summer they often feed in polar waters and then as winter approaches they go on long journeys towards the Equator.');

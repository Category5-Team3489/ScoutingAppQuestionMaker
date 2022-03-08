    this.questions = {
      Autonomous: [
        {
          id: 'AQ1',
          questionText: 'Cargo loaded at start of match?',
          questionType: 2,
          questionItems: [
            {
              value: 0,
              itemText: 'No'
            },
            {
              value: 1,
              itemText: 'Yes'
            }
          ],
          answer: 0
        },
        {
          id: 'AQ2',
          questionText: 'Fully exited the tarmac at least once?',
          questionType: 2,
          questionItems: [
            {
              value: 0,
              itemText: 'No'
            },
            {
              value: 1,
              itemText: 'Yes'
            }
          ],
          answer: 0
        },
        {
          id: 'AQ3',
          questionText: 'Cargo scored in low goal?',
          questionType: 1,
          questionItems: [
          ],
          answer: 0
        },
        {
          id: 'AQ4',
          questionText: 'Cargo scored in high goal?',
          questionType: 1,
          questionItems: [
          ],
          answer: 0
        },
        {
          id: 'AQ5',
          questionText: 'Human player shot cargo?',
          questionType: 2,
          questionItems: [
            {
              value: 0,
              itemText: 'N/A'
            },
            {
              value: 1,
              itemText: 'No'
            },
            {
              value: 2,
              itemText: 'Yes'
            }
          ],
          answer: 0
        }
      ],

      Teleop: [
        {
          id: 'TQ1',
          questionText: 'Cargo in low goal?',
          questionType: 1,
          questionItems: [
          ],
          answer: 0
        },
        {
          id: 'TQ2',
          questionText: 'Cargo in high goal?',
          questionType: 1,
          questionItems: [
          ],
          answer: 0
        },
        {
          id: 'TQ3',
          questionText: 'Max cargo ever in robot?',
          questionType: 2,
          questionItems: [
            {
              value: 0,
              itemText: '0'
            },
            {
              value: 1,
              itemText: '1'
            },
            {
              value: 2,
              itemText: '2'
            },
            {
              value: 3,
              itemText: '>2'
            }
          ],
          answer: 0
        }
      ],

      EndGame: [
        {
          id: 'EQ1',
          questionText: 'Bar climbed?',
          questionType: 2,
          questionItems: [
            {
              value: 0,
              itemText: 'No attempt'
            },
            {
              value: 1,
              itemText: 'Low'
            },
            {
              value: 2,
              itemText: 'Mid'
            },
            {
              value: 3,
              itemText: 'High'
            },
            {
              value: 4,
              itemText: 'Traversal'
            }
          ],
          answer: 0
        },
        {
          id: 'EQ2',
          questionText: 'Time taken to climb?',
          questionType: 1,
          questionItems: [
          ],
          answer: 0
        }
      ]
    };
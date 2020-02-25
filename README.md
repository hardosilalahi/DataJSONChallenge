# DataJSONChallenge
Refactory Task 3

We have JSON data like this

```json
[
  {
    "id": 323,
    "username": "rinood30",
    "profile": {
      "full_name": "Shabrina Fauzan",
      "birthday": "1988-10-30",
      "phones": [
        "08133473821",
        "082539163912"
      ]
    },
    "articles:": [
      {
        "id": 3,
        "title": "Tips Berbagi Makanan",
        "published_at": "2019-01-03T16:00:00"
      },
      {
        "id": 7,
        "title": "Cara Membakar Ikan",
        "published_at": "2019-01-07T14:00:00"
      }
    ]
  },
  {
    "id": 201,
    "username": "norisa",
    "profile": {
      "full_name": "Noor Annisa",
      "birthday": "1986-08-14",
      "phones": []
    },
    "articles:": [
      {
        "id": 82,
        "title": "Cara Membuat Kue Kering",
        "published_at": "2019-10-08T11:00:00"
      },
      {
        "id": 91,
        "title": "Cara Membuat Brownies",
        "published_at": "2019-11-11T13:00:00"
      },
      {
        "id": 31,
        "title": "Cara Membuat Brownies",
        "published_at": "2019-11-11T13:00:00"
      }
    ]
  },
  {
    "id": 42,
    "username": "karina",
    "profile": {
      "full_name": "Karina Triandini",
      "birthday": "1986-04-14",
      "phones": [
        "06133929341"
      ]
    },
    "articles:": []
  },
  {
    "id": 201,
    "username": "icha",
    "profile": {
      "full_name": "Annisa Rachmawaty",
      "birthday": "1987-12-30",
      "phones": []
    },
    "articles:": [
      {
        "id": 39,
        "title": "Tips Berbelanja Bulan Tua",
        "published_at": "2019-04-06T07:00:00"
      },
      {
        "id": 43,
        "title": "Cara Memilih Permainan di Steam",
        "published_at": "2019-06-11T05:00:00"
      },
      {
        "id": 58,
        "title": "Cara Membuat Brownies",
        "published_at": "2019-09-12T04:00:00"
      }
    ]
  }
]
```

Your tasks:

1. Find users who doesn't have any phone numbers.
2. Find users who have articles.
3. Find users who have "annis" on their name.
4. Find users who have articles on year 2020.
5. Find users who are born on 1986.
6. Find articles that contain "tips" on the title.
7. Find articles published before August 2019.

We have simple purchases data in JSON format

```json
[
  {
    "order_id": "SO-921",
    "created_at": "2018-02-17T03:24:12",
    "customer": { "id": 33, "name": "Ari" },
    "items": [
      { "id": 24, "name": "Sapu Lidi", "qty": 2, "price": 13200 }, 
      { "id": 73, "name": "Sprei 160x200 polos", "qty": 1, "price": 149000 }
    ]
  },
  {
    "order_id": "SO-922",
    "created_at": "2018-02-20T13:10:32",
    "customer": { "id": 40, "name": "Ririn" },
    "items": [
      { "id": 83, "name": "Rice Cooker", "qty": 1, "price": 258000 },
      { "id": 24, "name": "Sapu Lidi", "qty": 1, "price": 13200 }, 
      { "id": 30, "name": "Teflon", "qty": 1, "price": 190000 }
    ]
  },
  {
    "order_id": "SO-923",
    "created_at": "2018-02-28T15:20:43",
    "customer": { "id": 33, "name": "Ari" },
    "items": [
      { "id": 303, "name": "Pematik Api", "qty": 1, "price": 12000 }, 
      { "id": 49, "name": "Panci", "qty": 2, "price": 70000 }
    ]
  },
  {
    "order_id": "SO-924",
    "created_at": "2018-03-02T14:30:54",
    "customer": { "id": 40, "name": "Ririn" },
    "items": [
      { "id": 986, "name": "TV LCD 40 inch", "qty": 1, "price": 6000000 }
    ]
  },
  {
    "order_id": "SO-925",
    "created_at": "2018-03-03T14:52:22",
    "customer": { "id": 33, "name": "Ari" },
    "items": [
      { "id": 1033, "name": "Nintendo Switch", "qty": 1, "price": 4990000 }, 
      { "id": 2003, "name": "Macbook Air 11 inch 128 GB", "qty": 1, "price": 12000000 },
      { "id": 23, "name": "Pocari Sweat 600ML", "qty": 5, "price": 7000 }
    ]
  },
  {
    "order_id": "SO-926",
    "created_at": "2018-03-05T16:23:20",
    "customer": { "id": 58, "name": "Annis" },
    "items": [
      { "id": 24, "name": "Sapu Lidi", "qty": 3, "price": 13200 }
    ]
  }
]
```

You need to do three things:

1) Find all purchases made in February.

2) Find all purchases made by Ari, and add **grand total** by sum all total price of items. The output should only a number.

3) Find people who have purchases with **grand total** lower than `300000`. The output is an array of people name. Duplicate name is not allowed.

Here is the inventory data in JSON

```json
[
  {
    "inventory_id": 9382,
    "name": "Brown Chair",
    "type": "furniture",
    "tags": [
      "chair",
      "furniture",
      "brown"
    ],
    "purchased_at": 1579190471,
    "placement": {
      "room_id": 3,
      "name": "Meeting Room"
    }
  },
  {
    "inventory_id": 9380,
    "name": "Big Desk",
    "type": "furniture",
    "tags": [
      "desk",
      "furniture",
      "brown"
    ],
    "purchased_at": 1579190642,
    "placement": {
      "room_id": 3,
      "name": "Meeting Room"
    }
  },
  {
    "inventory_id": 2932,
    "name": "LG Monitor 50 inch",
    "type": "electronic",
    "tags": [
      "monitor"
    ],
    "purchased_at": 1579017842,
    "placement": {
      "room_id": 3,
      "name": "Lavender"
    }
  },
  {
    "inventory_id": 232,
    "name": "Sharp Pendingin Ruangan 2PK",
    "type": "electronic",
    "tags": [
      "ac"
    ],
    "purchased_at": 1578931442,
    "placement": {
      "room_id": 5,
      "name": "Dhanapala"
    }
  },
  {
    "inventory_id": 9382,
    "name": "Alat Makan",
    "type": "tableware",
    "tags": [
      "spoon",
      "fork",
      "tableware"
    ],
    "purchased_at": 1578672242,
    "placement": {
      "room_id": 10,
      "name": "Rajawali"
    }
  }
]
```

Your tasks:

1. Find items in Meeting Room, and save it to `items.json`.
2. Find all electronic devices, and save it to `electronic.json`.
3. Find all furnitures, and save it to `furnitures.json`.
4. Find all items was purchased at 16 Januari 2020, and save it to `purchased-at-2020-01-16.json`.
5. Find all items with brown color, `all-browns.json`.

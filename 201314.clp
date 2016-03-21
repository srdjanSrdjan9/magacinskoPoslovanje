(deftemplate rastojanje-do-cilja
        0 100 m
        (
                (jako-blizu (Z 10 20))
                (blizu (PI 20 40))
                (daleko (S 60 100))
        )

)

(deftemplate brzina
        0 180 kmh
        (
                (sporo (0 0)(30 1)(60 0))
                (brzo (40 0)(80 1)(100 0))
                (jako-brzo (80 0)(140 1))

        )

)


(deftemplate pritisak-na-kocnicu
        0 100 posto
        (
                (slab (0 0)(15 1)(30 0))
                (srednji (25 0)(50 1)(75 0))
                (jak (65 0)(90 1))
        )

)


(deftemplate navigacija
        (slot brzina_kretanja (type FUZZY-VALUE brzina))
        (slot cilj (type FUZZY-VALUE rastojanje-do-cilja))

)

(defrule p1
        (navigacija (brzina_kretanja brzo) (cilj jako-blizu))
        =>
        (assert (pritisak-na-kocnicu jak))

)

(defrule p2
        (navigacija (brzina_kretanja sporo) (cilj jako-blizu))
        =>
        (assert (pritisak-na-kocnicu srednji))

)

(defrule p3
        (navigacija (brzina_kretanja sporo) (cilj daleko))
        =>
        (assert (pritisak-na-kocnicu slab))

)


(defrule p4
        =>
        (printout t "Kolika je brzina? " crlf)
        (bind ?odg1 (read))
        (printout t "Koliko je ostalo do cilja? " crlf)
        (bind ?odg2 (read))
        (assert (navigacija (brzina_kretanja (PI 2 ?odg1)) (cilj (PI 2 ?odg2))))

)


(defrule p5
        (defazifikuj)
        (pritisak-na-kocnicu ?pritisak)
        =>
        (printout t "Defazifikovana vrednost je " (moment-defuzzify ?pritisak) crlf)

)

/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstdelone.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:40:13 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:40:30 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_lstdelone(t_list *list, void (*del)(void *))
{
	if (!list)
		return ;
	if (del)
	{
		del((void *)list->content);
		free(list);
		list = NULL;
	}
}
